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
    public static class StringUtility
    {
        public static bool Contains(this string stringIn, string searchString)
        {
            if (stringIn == null) return false;

            // ReSharper disable StringIndexOfIsCultureSpecific.1
            return (stringIn.IndexOf(searchString) > -1);
            // ReSharper restore StringIndexOfIsCultureSpecific.1
        }

        public static bool StartsWith(this string stringIn, string searchString)
        {
            if (stringIn == null) return false;

            // ReSharper disable StringIndexOfIsCultureSpecific.1
            return (stringIn.IndexOf(searchString) == 0);
            // ReSharper restore StringIndexOfIsCultureSpecific.1
        }
    }
}