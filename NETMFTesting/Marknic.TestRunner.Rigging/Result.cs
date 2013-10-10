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
    /// Tracking object for each test
    /// </summary>
    public class Result
    {
        public string MethodName { get; set; }
        public bool Succeeded { get; set; }
        public Exception Exception { get; set; }
    }
}
