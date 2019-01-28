using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGroup2.Models;

namespace BowlingGroup2.Test
{
    [TestClass]
    public class DieTests
    {
        /// <summary>
        /// Test to ensure an int is returned 
        /// </summary>
        [TestMethod]
        public void GetRandomNumberTest()
        {
            int nextBowl = Die.GetNextBowl(10);
            Assert.IsTrue(nextBowl.GetType() == typeof(int));
        }

        /// <summary>
        /// Test to ensure the genereated number is NEVER greater of lower than
        /// 0 or the passed in amount
        /// </summary>
        [TestMethod]
        public void DieAlwaysInPinRange()
        {
            for (int i = 0; i < 100; i++)
            {
                //Using 6 as the remaining pin vount for test
                int nextBowl = Die.GetNextBowl(6);
                Assert.IsTrue(nextBowl >= 0 && nextBowl <= 6);
            }
        }
    }
}
