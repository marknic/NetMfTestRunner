using System;
using Microsoft.SPOT;
using Marknic.TestRunner.Rigging;

namespace Marknic.TestRunner
{
    public class LogicalWithSetup
    {
        private readonly Robot robot;

        public LogicalWithSetup()
        {
            robot = new Robot { Name = "I" };
        }

        public void TestWhenMovingSpeedWillBeGreaterThen0()
        {
            robot.StartMoving();
            Assert.IsTrue(robot.CurrentSpeeed > 0);
        }
    }

    internal class Robot{
        
        public string Name { get; set; }

        public int CurrentSpeeed { get; set; }

        internal void StartMoving()
        {
            CurrentSpeeed = 10;
        }
    }
}
