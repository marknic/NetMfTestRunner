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
    /// <summary>
    /// Assertions for the test methods
    /// </summary>
    public static class Assert
    {
        public static void IsTrue(bool condition, string message)
        {
            if (!condition)
            {
                throw new Exception(message);
            }
        }

        public static void IsFalse(bool condition, string message)
        {
            if (condition)
            {
                throw new Exception(message);
            }
        }

        public static void IsTrue(bool condition)
        {
            if (!condition)
            {
                throw new Exception("Result should have been true - result was false");
            }
        }

        public static void IsFalse(bool condition)
        {
            if (condition)
            {
                throw new Exception("Result should have been false - result was true");
            }
        }

        public static void AreEqual(int expected, int actual)
        {
            if (expected != actual)
            {
                throw new Exception("Expected value: " + expected + " - Actual value: " + actual);
            }
        }

        public static void AreEqual(long expected, long actual)
        {
            if (expected != actual)
            {
                throw new Exception("Expected value: " + expected + " - Actual value: " + actual);
            }
        }

        public static void AreEqual(string expected, string actual)
        {
            if (expected != actual)
            {
                throw new Exception("Expected value: " + expected + " - Actual value: " + actual);
            }
        }

        public static void IsNotNull(object actual)
        {
            if (actual == null)
            {
                throw new Exception("Object tested was null");
            }
        }

        public static void IsNull(object actual)
        {
            if (actual != null)
            {
                throw new Exception("Object tested was not null");
            }
        }

        public static void AreEqual(object expected, object actual)
        {
            if (expected == null)
            {
                throw new Exception("Expected object was null");
            }

            if (actual == null)
            {
                throw new Exception("actual object was null");
            }

            if (expected != actual)
            {
                throw new Exception("Objects are not the same: " + expected + " - Actual: " + actual);
            }
        }
    }
}
