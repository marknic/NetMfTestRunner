using System;

// ==============================================================================================
// .NET MicroFramework TestRunner
//
// Author: Mark S. Nichols
//
// Copyright (c) 2013 Mark Nichols
//
// This source is subject to the Microsoft Permissive License. 
// ==============================================================================================

namespace NETMFTesting
{
    public class MyLogic
    {
        /// <summary>
        /// This method will calculate the velocity of a robot based on wheel diameter
        /// and revolutions per minute
        /// </summary>
        /// <param name="radius">What is the radius of your wheel</param>
        /// <param name="rpm">How fast is the wheel revolving</param>
        /// <returns>Depending on the unit of measure of the radius, 
        /// this will be the velocity in a given minute</returns>
        public int HowFastIsMyRobotMoving(int radius, int rpm)
        {
            if (radius <= 0) throw new ArgumentException("radius must be a positive number");
            
            var velocity = (int)(2 * radius * Math.PI * rpm);

            return velocity;
        }
    }
}