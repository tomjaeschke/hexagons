using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Damisam.MathematicsCalculations.Tests
{
    [TestClass]
    public class RingSegmentTester
    {
        public RingSegmentTester()
        {
        }

        [TestMethod]
        public void test_numeric_values_for_RingSegment()
        {
            RingSegment ringSegment = RingSegment.EastByNortheast;
            Assert.AreEqual(ringSegment, RingSegment.EastByNortheast);
            Assert.AreEqual(Convert.ToInt32(ringSegment), 1);
            ringSegment = RingSegment.WestBySouthwest;
            Assert.AreEqual(ringSegment, RingSegment.WestBySouthwest);
            Assert.AreEqual(Convert.ToInt32(ringSegment), 4);
            ringSegment = RingSegment.North;
            Assert.AreEqual(ringSegment, RingSegment.North);
            Assert.AreEqual(Convert.ToInt32(ringSegment), 6);
        }
    }
}