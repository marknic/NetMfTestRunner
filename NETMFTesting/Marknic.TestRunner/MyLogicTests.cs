using Marknic.TestRunner.Rigging;
using NETMFTesting;

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
    public class MyLogicTests
    {
        // Method proves that the logic will throw the expected exception
        public void TestEx_MyLogicTests_WhenPassingNegativeRadiusShouldThrowException()
        {
            var myLogic = new MyLogic();

            myLogic.HowFastIsMyRobotMoving(-1, 100);
        }

        // Method proves that the logic will throw the expected exception
        public void TestEx_MyLogicTests_WhenPassingZeroRadiusShouldThrowException()
        {
            var myLogic = new MyLogic();

            myLogic.HowFastIsMyRobotMoving(0, 100);
        }

        // Method proves that the logic will calculate properly
        public void Test_MyLogicTests_WhenPassingValidValuesShouldCalculateAnswer()
        {
            // Arrange
            var myLogic = new MyLogic();

            // Act
            var actual = myLogic.HowFastIsMyRobotMoving(10, 100);

            // Assert
            // Expected result came from external calculation where I used Excel to calculate
            // the number
            Assert.AreEqual(6283, actual);
        }

        // This test example will fail since I'm not rounding in my calculation, I'm truncating
        public void Test_MyLogicTests_WhenPassingValidValuesShouldRoundProperly()
        {
            // Arrange
            var myLogic = new MyLogic();

            // Act
            var actual = myLogic.HowFastIsMyRobotMoving(6, -100);

            // Assert
            // Expected result came from external calculation where I used Excel to calculate
            // the number
            Assert.AreEqual(-3770, actual);
        }

    }
}
