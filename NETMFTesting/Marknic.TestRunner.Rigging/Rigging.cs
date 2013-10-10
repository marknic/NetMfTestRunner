using System;
using System.Collections;
using System.Reflection;
using Microsoft.SPOT;

// ==============================================================================================
// .NET MicroFramework TestRunner
//
// Author: Mark S. Nichols
//
// Copyright (c) 2013 Mark Nichols
//
// This source is subject to the Microsoft Permissive License. 
// ==============================================================================================

namespace Marknic.TestRunner.Rigging
{
    public static class TestRig
    {
        private static readonly ArrayList ResultList = new ArrayList();
        private static int _totalCount;
        private static int _failureCount;

        /// <summary>
        /// This method accepts an assembly that contains test methods (as defined by naming convention
        /// in that all test methods begin with Test or TestEx)
        /// </summary>
        /// <param name="assembly">Assembly containing test methods</param>
        public static void ExecuteTests(Assembly assembly)
        {
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                var methodList = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

                foreach (var method in methodList)
                {
                    // Do we have a test?
                    if (!method.Name.StartsWith("Test")) continue;

                    _totalCount++;

                    var result = new Result { MethodName = method.Name, Succeeded = true };

                    // Are we testing that the method throws an exception?
                    if (method.Name.StartsWith("TestEx"))
                    {
                        result.Succeeded = false;
                    }

                    try
                    {
                        method.Invoke(null, null);

                        // If an exception was expected then create one for reporting
                        if (!result.Succeeded)
                        {
                            result.Exception = new Exception("An exception should have been thrown");
                        }
                    }
                    catch (Exception ex)
                    {
                        result.Succeeded = !result.Succeeded;
                        result.Exception = ex;
                    }

                    if (!result.Succeeded) _failureCount++;

                    ResultList.Add(result);
                }
            }

            DisplayTestResults();
        }

        /// <summary>
        /// Reporting method - displays results following the test run
        /// </summary>
        private static void DisplayTestResults()
        {
            Debug.Print("\n");
            Debug.Print("-------------------------------------------------------------");
            Debug.Print("Test Results");
            Debug.Print("-------------------------------------------------------------");
            Debug.Print("     Total Tests: " + _totalCount);
            Debug.Print("Successful Tests: " + (_totalCount - _failureCount));
            Debug.Print("   Test Failures: " + _failureCount);
            Debug.Print("\n");

            Debug.Print("Failed Tests:");
            Debug.Print("-------------------------------------------------------------");
            foreach (Result result in ResultList)
            {
                if (!result.Succeeded)
                {
                    Debug.Print("Name: " + result.MethodName + " - Reason: " + result.Exception.Message);
                }
            }
            Debug.Print("-------------------------------------------------------------\n");
        }
    }
}
