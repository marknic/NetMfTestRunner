using System.Reflection;
using Marknic.TestRunner.Rigging;

// ==============================================================================================
// .NET MicroFramework TestRunner
//
// Author: Mark S. Nichols
//
// Copyright (c) 2013 Mark Nichols
//
// This source is subject to the Microsoft Permissive License. 
// ==============================================================================================

namespace Marknic.TestRunner
{
    public class TestRunner
    {        
        public static void Main()
        {
            TestRig.ExecuteTests(Assembly.GetExecutingAssembly());
        }
    }
}