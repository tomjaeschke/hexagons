using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Damisam.MathematicsCalculations.Tests
{
    [TestClass]
    public class TerritoryTester
    {
        public TerritoryTester()
        {
        }

        [TestMethod]
        public void able_to_calculate_five_navigation_crutches()
        {
            Territory territory = new Territory();
            territory.hexagon = 1;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 0);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 7);

            territory.hexagon = 2;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 0);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 9);

            territory.hexagon = 3;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.South;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 0);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 11);

            territory.hexagon = 4;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 0);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 13);

            territory.hexagon = 5;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 0);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 15);

            territory.hexagon = 6;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.North;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 0);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 17);

            territory.hexagon = 7;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 1);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 19);

            territory.hexagon = 8;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 1);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 19);

            territory.hexagon = 9;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 2);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 22);

            territory.hexagon = 10;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 2);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 22);

            territory.hexagon = 11;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.South;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 3);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 25);

            territory.hexagon = 12;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.South;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 3);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 25);

            territory.hexagon = 13;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 4);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 28);

            territory.hexagon = 14;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 4);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 28);

            territory.hexagon = 15;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 5);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 31);

            territory.hexagon = 16;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 5);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 31);

            territory.hexagon = 17;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.North;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 6);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 34);

            territory.hexagon = 18;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.North;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 6);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 34);

            territory.hexagon = 37;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 19);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 61);

            territory.hexagon = 38;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 19);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 61);

            territory.hexagon = 39;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 3);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 19);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 61);

            territory.hexagon = 40;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 4);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 19);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 61);

            territory.hexagon = 41;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 22);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 66);

            territory.hexagon = 42;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 22);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 66);

            territory.hexagon = 43;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 3);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 22);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 66);

            territory.hexagon = 44;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 4);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 22);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 66);

            territory.hexagon = 45;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.South;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 25);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 71);

            territory.hexagon = 46;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.South;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 25);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 71);

            territory.hexagon = 47;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.South;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 3);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 25);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 71);

            territory.hexagon = 48;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.South;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 4);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 25);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 71);

            territory.hexagon = 49;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 28);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 76);

            territory.hexagon = 50;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 28);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 76);

            territory.hexagon = 51;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 3);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 28);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 76);

            territory.hexagon = 52;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 4);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 28);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 76);

            territory.hexagon = 53;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 31);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 81);

            territory.hexagon = 54;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 31);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 81);

            territory.hexagon = 55;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 3);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 31);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 81);

            territory.hexagon = 56;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 4);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 31);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 81);

            territory.hexagon = 57;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.North;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 34);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 86);

            territory.hexagon = 58;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.North;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 34);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 86);

            territory.hexagon = 59;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.North;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 3);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 34);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 86);

            territory.hexagon = 60;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.North;
            territory.CalculateFiveNavigationCrutches();
            Assert.AreEqual(territory.depthIntoRingSegment, 4);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 34);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 86);
        }

        [TestMethod]
        public void able_to_calculate_inner_ring()
        {
            Territory territory = new Territory();
            territory.ring = 0;
            territory.innerRing = territory.CalculateInnerRing();
            Assert.AreEqual(territory.innerRing, null);

            territory.ring = 1;
            territory.innerRing = territory.CalculateInnerRing();
            Assert.AreEqual(territory.innerRing, 0);

            territory.ring = 2;
            territory.innerRing = territory.CalculateInnerRing();
            Assert.AreEqual(territory.innerRing, 1);

            territory.ring = 3;
            territory.innerRing = territory.CalculateInnerRing();
            Assert.AreEqual(territory.innerRing, 2);
        }

        [TestMethod]
        public void able_to_calculate_item_count_in_bowling_ball_pin_arrangement_given_number_of_rows_in_arrangement()
        {
            Territory territory = new Territory();
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(0), 0);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(1), 1);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(2), 3);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(3), 6);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(4), 10);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(5), 15);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(6), 21);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(7), 28);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(8), 36);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(9), 45);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(10), 55);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(11), 66);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(12), 78);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(13), 91);
            Assert.AreEqual(territory.CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(14), 105);
        }

        [TestMethod]
        public void able_to_calculate_hexagons_in_inner_rings()
        {
            Territory territory = new Territory();
            Assert.AreEqual(territory.CalculateHexagonsInInnerRingsWithoutHexagonZero(), 0);

            territory.innerRing = null;
            Assert.AreEqual(territory.CalculateHexagonsInInnerRingsWithoutHexagonZero(), 0);

            territory.innerRing = 0;
            Assert.AreEqual(territory.CalculateHexagonsInInnerRingsWithoutHexagonZero(), 0);

            territory.innerRing = 1;
            Assert.AreEqual(territory.CalculateHexagonsInInnerRingsWithoutHexagonZero(), 6);

            territory.innerRing = 2;
            Assert.AreEqual(territory.CalculateHexagonsInInnerRingsWithoutHexagonZero(), 18);

            territory.innerRing = 3;
            Assert.AreEqual(territory.CalculateHexagonsInInnerRingsWithoutHexagonZero(), 36);
        }

        [TestMethod]
        public void able_to_calculate_outer_ring()
        {
            Territory territory = new Territory();
            territory.ring = 0;
            territory.outerRing = territory.CalculateOuterRing();
            Assert.AreEqual(territory.outerRing, 1);

            territory.ring = 1;
            territory.outerRing = territory.CalculateOuterRing();
            Assert.AreEqual(territory.outerRing, 2);

            territory.ring = 2;
            territory.outerRing = territory.CalculateOuterRing();
            Assert.AreEqual(territory.outerRing, 3);

            territory.ring = 3;
            territory.outerRing = territory.CalculateOuterRing();
            Assert.AreEqual(territory.outerRing, 4);
        }

        [TestMethod]
        public void able_to_calculate_ring()
        {
            Territory territory = new Territory();
            territory.hexagon = 0;
            Assert.AreEqual(territory.CalculateRing(), 0);

            territory.hexagon = 1;
            Assert.AreEqual(territory.CalculateRing(), 1);

            territory.hexagon = 2;
            Assert.AreEqual(territory.CalculateRing(), 1);

            territory.hexagon = 3;
            Assert.AreEqual(territory.CalculateRing(), 1);

            territory.hexagon = 4;
            Assert.AreEqual(territory.CalculateRing(), 1);

            territory.hexagon = 5;
            Assert.AreEqual(territory.CalculateRing(), 1);

            territory.hexagon = 6;
            Assert.AreEqual(territory.CalculateRing(), 1);

            territory.hexagon = 7;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 8;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 9;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 10;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 11;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 12;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 13;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 14;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 15;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 16;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 17;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 18;
            Assert.AreEqual(territory.CalculateRing(), 2);

            territory.hexagon = 19;
            Assert.AreEqual(territory.CalculateRing(), 3);

            territory.hexagon = 20;
            Assert.AreEqual(territory.CalculateRing(), 3);
        }

        [TestMethod]
        public void able_to_calculate_row_in_bowling_ball_pin_arrangement_for_given_pin()
        {
            Territory territory = new Territory();
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(0), 0);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(1), 1);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(2), 2);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(3), 2);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(4), 3);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(5), 3);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(6), 3);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(7), 4);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(8), 4);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(9), 4);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(10), 4);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(11), 5);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(12), 5);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(13), 5);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(14), 5);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(15), 5);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(16), 6);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(17), 6);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(18), 6);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(19), 6);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(20), 6);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(21), 6);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(22), 7);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(23), 7);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(24), 7);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(25), 7);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(26), 7);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(27), 7);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(28), 7);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(29), 8);
            Assert.AreEqual(territory.DetermineRowInBowlingBallPinArrangementForGivenPin(30), 8);
        }

        [TestMethod]
        public void able_to_divide_by_six_while_rounding_up()
        {
            Territory territory = new Territory();
            territory.hexagon = 0;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 0);

            territory.hexagon = 1;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 1);

            territory.hexagon = 2;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 1);

            territory.hexagon = 3;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 1);

            territory.hexagon = 4;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 1);

            territory.hexagon = 5;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 1);

            territory.hexagon = 6;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 1);

            territory.hexagon = 7;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 2);

            territory.hexagon = 12;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 2);

            territory.hexagon = 18;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 3);

            territory.hexagon = 19;
            Assert.AreEqual(territory.DivideHexagonBySixWhileRoundingUp(), 4);
        }

        [TestMethod]
        public void able_to_find_neighboring_territories_given_EastByNortheast_RingSegment()
        {
            Territory territory = new Territory();
            territory.hexagon = 1;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 0;
            territory.beginningOfAdjacentOuterRingSegment = 7;
            territory.FindNeighboringTerritoriesGivenEastByNortheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 8);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 9);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 2);
            Assert.AreEqual(territory.hexagonToTheWest, 0);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 6);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 7);

            territory.hexagon = 7;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 1;
            territory.beginningOfAdjacentOuterRingSegment = 19;
            territory.FindNeighboringTerritoriesGivenEastByNortheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 20);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 8);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 1);
            Assert.AreEqual(territory.hexagonToTheWest, 6);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 18);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 19);

            territory.hexagon = 8;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 1;
            territory.beginningOfAdjacentOuterRingSegment = 19;
            territory.FindNeighboringTerritoriesGivenEastByNortheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 21);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 22);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 9);
            Assert.AreEqual(territory.hexagonToTheWest, 1);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 7);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 20);

            territory.hexagon = 37;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 19;
            territory.beginningOfAdjacentOuterRingSegment = 61;
            territory.FindNeighboringTerritoriesGivenEastByNortheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 62);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 38);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 19);
            Assert.AreEqual(territory.hexagonToTheWest, 36);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 60);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 61);

            territory.hexagon = 38;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 19;
            territory.beginningOfAdjacentOuterRingSegment = 61;
            territory.FindNeighboringTerritoriesGivenEastByNortheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 63);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 39);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 20);
            Assert.AreEqual(territory.hexagonToTheWest, 19);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 37);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 62);

            territory.hexagon = 39;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.depthIntoRingSegment = 3;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 19;
            territory.beginningOfAdjacentOuterRingSegment = 61;
            territory.FindNeighboringTerritoriesGivenEastByNortheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 64);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 40);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 21);
            Assert.AreEqual(territory.hexagonToTheWest, 20);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 38);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 63);

            territory.hexagon = 40;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.depthIntoRingSegment = 4;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 19;
            territory.beginningOfAdjacentOuterRingSegment = 61;
            territory.FindNeighboringTerritoriesGivenEastByNortheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 65);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 66);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 41);
            Assert.AreEqual(territory.hexagonToTheWest, 21);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 39);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 64);
        }

        [TestMethod]
        public void able_to_find_neighboring_territories_given_EastBySoutheast_RingSegment()
        {
            Territory territory = new Territory();
            territory.hexagon = 2;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 0;
            territory.beginningOfAdjacentOuterRingSegment = 9;
            territory.FindNeighboringTerritoriesGivenEastBySoutheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 9);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 10);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 11);
            Assert.AreEqual(territory.hexagonToTheWest, 3);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 0);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 1);

            territory.hexagon = 9;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 2;
            territory.beginningOfAdjacentOuterRingSegment = 22;
            territory.FindNeighboringTerritoriesGivenEastBySoutheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 22);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 23);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 10);
            Assert.AreEqual(territory.hexagonToTheWest, 2);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 1);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 8);

            territory.hexagon = 10;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 2;
            territory.beginningOfAdjacentOuterRingSegment = 22;
            territory.FindNeighboringTerritoriesGivenEastBySoutheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 23);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 24);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 25);
            Assert.AreEqual(territory.hexagonToTheWest, 11);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 2);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 9);

            territory.hexagon = 41;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 22;
            territory.beginningOfAdjacentOuterRingSegment = 66;
            territory.FindNeighboringTerritoriesGivenEastBySoutheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 66);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 67);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 42);
            Assert.AreEqual(territory.hexagonToTheWest, 22);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 21);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 40);

            territory.hexagon = 42;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 22;
            territory.beginningOfAdjacentOuterRingSegment = 66;
            territory.FindNeighboringTerritoriesGivenEastBySoutheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 67);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 68);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 43);
            Assert.AreEqual(territory.hexagonToTheWest, 23);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 22);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 41);

            territory.hexagon = 43;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.depthIntoRingSegment = 3;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 22;
            territory.beginningOfAdjacentOuterRingSegment = 66;
            territory.FindNeighboringTerritoriesGivenEastBySoutheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 68);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 69);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 44);
            Assert.AreEqual(territory.hexagonToTheWest, 24);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 23);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 42);

            territory.hexagon = 44;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.EastBySoutheast;
            territory.depthIntoRingSegment = 4;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 22;
            territory.beginningOfAdjacentOuterRingSegment = 66;
            territory.FindNeighboringTerritoriesGivenEastBySoutheastRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 69);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 70);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 71);
            Assert.AreEqual(territory.hexagonToTheWest, 45);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 24);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 43);
        }

        [TestMethod]
        public void able_to_find_neighboring_territories_given_North_RingSegment()
        {
            Territory territory = new Territory();
            territory.hexagon = 6;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.North;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 0;
            territory.beginningOfAdjacentOuterRingSegment = 17;
            territory.FindNeighboringTerritoriesGivenNorthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 7);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 1);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 0);
            Assert.AreEqual(territory.hexagonToTheWest, 5);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 17);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 18);

            territory.hexagon = 17;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.North;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 6;
            territory.beginningOfAdjacentOuterRingSegment = 34;
            territory.FindNeighboringTerritoriesGivenNorthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 18);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 6);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 5);
            Assert.AreEqual(territory.hexagonToTheWest, 16);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 34);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 35);

            territory.hexagon = 18;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.North;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 6;
            territory.beginningOfAdjacentOuterRingSegment = 34;
            territory.FindNeighboringTerritoriesGivenNorthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 19);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 7);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 6);
            Assert.AreEqual(territory.hexagonToTheWest, 17);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 35);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 36);

            territory.hexagon = 57;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.North;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 34;
            territory.beginningOfAdjacentOuterRingSegment = 86;
            territory.FindNeighboringTerritoriesGivenNorthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 58);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 34);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 33);
            Assert.AreEqual(territory.hexagonToTheWest, 56);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 86);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 87);

            territory.hexagon = 58;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.North;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 34;
            territory.beginningOfAdjacentOuterRingSegment = 86;
            territory.FindNeighboringTerritoriesGivenNorthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 59);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 35);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 34);
            Assert.AreEqual(territory.hexagonToTheWest, 57);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 87);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 88);

            territory.hexagon = 59;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.North;
            territory.depthIntoRingSegment = 3;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 34;
            territory.beginningOfAdjacentOuterRingSegment = 86;
            territory.FindNeighboringTerritoriesGivenNorthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 60);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 36);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 35);
            Assert.AreEqual(territory.hexagonToTheWest, 58);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 88);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 89);

            territory.hexagon = 60;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.North;
            territory.depthIntoRingSegment = 4;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 34;
            territory.beginningOfAdjacentOuterRingSegment = 86;
            territory.FindNeighboringTerritoriesGivenNorthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 61);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 37);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 36);
            Assert.AreEqual(territory.hexagonToTheWest, 59);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 89);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 90);
        }

        [TestMethod]
        public void able_to_find_neighboring_territories_given_South_RingSegment()
        {
            Territory territory = new Territory();
            territory.hexagon = 3;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.South;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 0;
            territory.beginningOfAdjacentOuterRingSegment = 11;
            territory.FindNeighboringTerritoriesGivenSouthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 2);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 11);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 12);
            Assert.AreEqual(territory.hexagonToTheWest, 13);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 4);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 0);

            territory.hexagon = 11;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.South;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 3;
            territory.beginningOfAdjacentOuterRingSegment = 25;
            territory.FindNeighboringTerritoriesGivenSouthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 10);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 25);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 26);
            Assert.AreEqual(territory.hexagonToTheWest, 12);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 3);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 2);

            territory.hexagon = 12;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.South;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 3;
            territory.beginningOfAdjacentOuterRingSegment = 25;
            territory.FindNeighboringTerritoriesGivenSouthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 11);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 26);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 27);
            Assert.AreEqual(territory.hexagonToTheWest, 28);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 13);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 3);

            territory.hexagon = 45;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.South;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 25;
            territory.beginningOfAdjacentOuterRingSegment = 71;
            territory.FindNeighboringTerritoriesGivenSouthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 44);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 71);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 72);
            Assert.AreEqual(territory.hexagonToTheWest, 46);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 25);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 24);

            territory.hexagon = 46;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.South;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 25;
            territory.beginningOfAdjacentOuterRingSegment = 71;
            territory.FindNeighboringTerritoriesGivenSouthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 45);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 72);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 73);
            Assert.AreEqual(territory.hexagonToTheWest, 47);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 26);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 25);

            territory.hexagon = 47;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.South;
            territory.depthIntoRingSegment = 3;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 25;
            territory.beginningOfAdjacentOuterRingSegment = 71;
            territory.FindNeighboringTerritoriesGivenSouthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 46);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 73);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 74);
            Assert.AreEqual(territory.hexagonToTheWest, 48);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 27);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 26);

            territory.hexagon = 48;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.South;
            territory.depthIntoRingSegment = 4;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 25;
            territory.beginningOfAdjacentOuterRingSegment = 71;
            territory.FindNeighboringTerritoriesGivenSouthRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 47);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 74);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 75);
            Assert.AreEqual(territory.hexagonToTheWest, 76);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 49);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 27);
        }

        [TestMethod]
        public void able_to_find_neighboring_territories_given_WestByNorthwest_RingSegment()
        {
            Territory territory = new Territory();
            territory.hexagon = 5;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 0;
            territory.beginningOfAdjacentOuterRingSegment = 15;
            territory.FindNeighboringTerritoriesGivenWestByNorthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 6);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 0);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 4);
            Assert.AreEqual(territory.hexagonToTheWest, 15);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 16);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 17);

            territory.hexagon = 15;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 5;
            territory.beginningOfAdjacentOuterRingSegment = 31;
            territory.FindNeighboringTerritoriesGivenWestByNorthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 5);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 4);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 14);
            Assert.AreEqual(territory.hexagonToTheWest, 31);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 32);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 16);

            territory.hexagon = 16;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 5;
            territory.beginningOfAdjacentOuterRingSegment = 31;
            territory.FindNeighboringTerritoriesGivenWestByNorthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 17);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 5);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 15);
            Assert.AreEqual(territory.hexagonToTheWest, 32);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 33);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 34);

            territory.hexagon = 53;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 31;
            territory.beginningOfAdjacentOuterRingSegment = 81;
            territory.FindNeighboringTerritoriesGivenWestByNorthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 31);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 30);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 52);
            Assert.AreEqual(territory.hexagonToTheWest, 81);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 82);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 54);

            territory.hexagon = 54;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 31;
            territory.beginningOfAdjacentOuterRingSegment = 81;
            territory.FindNeighboringTerritoriesGivenWestByNorthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 32);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 31);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 53);
            Assert.AreEqual(territory.hexagonToTheWest, 82);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 83);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 55);

            territory.hexagon = 55;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.depthIntoRingSegment = 3;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 31;
            territory.beginningOfAdjacentOuterRingSegment = 81;
            territory.FindNeighboringTerritoriesGivenWestByNorthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 33);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 32);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 54);
            Assert.AreEqual(territory.hexagonToTheWest, 83);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 84);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 56);

            territory.hexagon = 56;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestByNorthwest;
            territory.depthIntoRingSegment = 4;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 31;
            territory.beginningOfAdjacentOuterRingSegment = 81;
            territory.FindNeighboringTerritoriesGivenWestByNorthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 57);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 33);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 55);
            Assert.AreEqual(territory.hexagonToTheWest, 84);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 85);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 86);
        }

        [TestMethod]
        public void able_to_find_neighboring_territories_given_WestBySouthwest_RingSegment()
        {
            Territory territory = new Territory();
            territory.hexagon = 4;
            territory.innerRing = 0;
            territory.ring = 1;
            territory.outerRing = 2;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 0;
            territory.beginningOfAdjacentOuterRingSegment = 13;
            territory.FindNeighboringTerritoriesGivenWestBySouthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 0);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 3);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 13);
            Assert.AreEqual(territory.hexagonToTheWest, 14);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 15);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 5);

            territory.hexagon = 13;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 4;
            territory.beginningOfAdjacentOuterRingSegment = 28;
            territory.FindNeighboringTerritoriesGivenWestBySouthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 3);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 12);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 28);
            Assert.AreEqual(territory.hexagonToTheWest, 29);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 14);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 4);

            territory.hexagon = 14;
            territory.innerRing = 1;
            territory.ring = 2;
            territory.outerRing = 3;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 4;
            territory.beginningOfAdjacentOuterRingSegment = 28;
            territory.FindNeighboringTerritoriesGivenWestBySouthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 4);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 13);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 29);
            Assert.AreEqual(territory.hexagonToTheWest, 30);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 31);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 15);

            territory.hexagon = 49;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.depthIntoRingSegment = 1;
            territory.atBeginningOfRingSegment = true;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 28;
            territory.beginningOfAdjacentOuterRingSegment = 76;
            territory.FindNeighboringTerritoriesGivenWestBySouthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 27);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 48);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 76);
            Assert.AreEqual(territory.hexagonToTheWest, 77);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 50);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 28);

            territory.hexagon = 50;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.depthIntoRingSegment = 2;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 28;
            territory.beginningOfAdjacentOuterRingSegment = 76;
            territory.FindNeighboringTerritoriesGivenWestBySouthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 28);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 49);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 77);
            Assert.AreEqual(territory.hexagonToTheWest, 78);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 51);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 29);

            territory.hexagon = 51;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.depthIntoRingSegment = 3;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = false;
            territory.beginningOfAdjacentInnerRingSegment = 28;
            territory.beginningOfAdjacentOuterRingSegment = 76;
            territory.FindNeighboringTerritoriesGivenWestBySouthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 29);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 50);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 78);
            Assert.AreEqual(territory.hexagonToTheWest, 79);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 52);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 30);

            territory.hexagon = 52;
            territory.innerRing = 3;
            territory.ring = 4;
            territory.outerRing = 5;
            territory.ringSegment = RingSegment.WestBySouthwest;
            territory.depthIntoRingSegment = 4;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.beginningOfAdjacentInnerRingSegment = 28;
            territory.beginningOfAdjacentOuterRingSegment = 76;
            territory.FindNeighboringTerritoriesGivenWestBySouthwestRingSegment();
            Assert.AreEqual(territory.hexagonToTheEast, 30);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 51);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 79);
            Assert.AreEqual(territory.hexagonToTheWest, 80);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 81);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 53);
        }

        [TestMethod]
        public void able_to_set_ring_segment()
        {
            Territory territory = new Territory();
            territory.hexagon = 0;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, null);

            territory.hexagon = 1;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.EastByNortheast);

            territory.hexagon = 2;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.EastBySoutheast);

            territory.hexagon = 3;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.South);

            territory.hexagon = 4;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.WestBySouthwest);

            territory.hexagon = 5;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.WestByNorthwest);

            territory.hexagon = 6;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.North);

            territory.hexagon = 7;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.EastByNortheast);

            territory.hexagon = 8;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.EastByNortheast);

            territory.hexagon = 9;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.EastBySoutheast);

            territory.hexagon = 10;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.EastBySoutheast);

            territory.hexagon = 11;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.South);

            territory.hexagon = 12;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.South);

            territory.hexagon = 13;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.WestBySouthwest);

            territory.hexagon = 14;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.WestBySouthwest);

            territory.hexagon = 15;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.WestByNorthwest);

            territory.hexagon = 16;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.WestByNorthwest);

            territory.hexagon = 17;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.North);

            territory.hexagon = 18;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.North);

            territory.hexagon = 19;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.EastByNortheast);

            territory.hexagon = 20;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.EastByNortheast);

            territory.hexagon = 50;
            territory.ring = territory.CalculateRing();
            territory.innerRing = territory.CalculateInnerRing();
            territory.SetRingSegment();
            Assert.AreEqual(territory.ringSegment, RingSegment.WestBySouthwest);
        }

        [TestMethod]
        public void first_seven_Territories_have_the_TerritoryColors_expected()
        {
            Territory territory = new Territory(0);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(1);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(2);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(3);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(4);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(5);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(6);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
        }

        [TestMethod]
        public void may_calculate_Territory_specifications_at_Territory_creation()
        {
            Territory territory = new Territory(1);
            Assert.AreEqual(territory.hexagon, 1);
            Assert.AreEqual(territory.ring, 1);
            Assert.AreEqual(territory.ringSegment, RingSegment.EastByNortheast);
            Assert.AreEqual(Convert.ToInt32(territory.ringSegment), 1);
            Assert.AreEqual(territory.innerRing, 0);
            Assert.AreEqual(territory.outerRing, 2);
            Assert.AreEqual(territory.hexagonToTheEast, 8);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 9);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 2);
            Assert.AreEqual(territory.hexagonToTheWest, 0);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 6);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 7);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 0);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 7);

            territory = new Territory(2);
            Assert.AreEqual(territory.hexagon, 2);
            Assert.AreEqual(territory.ring, 1);
            Assert.AreEqual(territory.ringSegment, RingSegment.EastBySoutheast);
            Assert.AreEqual(Convert.ToInt32(territory.ringSegment), 2);
            Assert.AreEqual(territory.innerRing, 0);
            Assert.AreEqual(territory.outerRing, 2);
            Assert.AreEqual(territory.hexagonToTheEast, 9);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 10);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 11);
            Assert.AreEqual(territory.hexagonToTheWest, 3);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 0);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 1);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 0);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 9);

            territory = new Territory(12);
            Assert.AreEqual(territory.hexagon, 12);
            Assert.AreEqual(territory.ring, 2);
            Assert.AreEqual(territory.ringSegment, RingSegment.South);
            Assert.AreEqual(Convert.ToInt32(territory.ringSegment), 3);
            Assert.AreEqual(territory.innerRing, 1);
            Assert.AreEqual(territory.outerRing, 3);
            Assert.AreEqual(territory.hexagonToTheEast, 11);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 26);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 27);
            Assert.AreEqual(territory.hexagonToTheWest, 28);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 13);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 3);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 3);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 25);

            territory = new Territory(29);
            Assert.AreEqual(territory.hexagon, 29);
            Assert.AreEqual(territory.ring, 3);
            Assert.AreEqual(territory.ringSegment, RingSegment.WestBySouthwest);
            Assert.AreEqual(Convert.ToInt32(territory.ringSegment), 4);
            Assert.AreEqual(territory.innerRing, 2);
            Assert.AreEqual(territory.outerRing, 4);
            Assert.AreEqual(territory.hexagonToTheEast, 13);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 28);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 50);
            Assert.AreEqual(territory.hexagonToTheWest, 51);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 30);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 14);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 13);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 49);

            territory = new Territory(53);
            Assert.AreEqual(territory.hexagon, 53);
            Assert.AreEqual(territory.ring, 4);
            Assert.AreEqual(territory.ringSegment, RingSegment.WestByNorthwest);
            Assert.AreEqual(Convert.ToInt32(territory.ringSegment), 5);
            Assert.AreEqual(territory.innerRing, 3);
            Assert.AreEqual(territory.outerRing, 5);
            Assert.AreEqual(territory.hexagonToTheEast, 31);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 30);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 52);
            Assert.AreEqual(territory.hexagonToTheWest, 81);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 82);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 54);
            Assert.AreEqual(territory.atBeginningOfRingSegment, true);
            Assert.AreEqual(territory.atEndOfRingSegment, false);
            Assert.AreEqual(territory.depthIntoRingSegment, 1);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 31);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 81);

            territory = new Territory(60);
            Assert.AreEqual(territory.hexagon, 60);
            Assert.AreEqual(territory.ring, 4);
            Assert.AreEqual(territory.ringSegment, RingSegment.North);
            Assert.AreEqual(Convert.ToInt32(territory.ringSegment), 6);
            Assert.AreEqual(territory.innerRing, 3);
            Assert.AreEqual(territory.outerRing, 5);
            Assert.AreEqual(territory.hexagonToTheEast, 61);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 37);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 36);
            Assert.AreEqual(territory.hexagonToTheWest, 59);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 89);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 90);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.depthIntoRingSegment, 4);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 34);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 86);
        }

        [TestMethod]
        public void may_determine_what_TerritoryColor_a_Territory_is_based_upon_the_colors_adjacent_to_it()
        {
            Territory territory = new Territory();
            Assert.AreEqual(territory.territoryColor, null);
            territory.CalculateWhichTerritoryColorTwoDifferentTerritoryColorsAreNot(TerritoryColor.Central, TerritoryColor.JustEastOfCentral);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory.CalculateWhichTerritoryColorTwoDifferentTerritoryColorsAreNot(TerritoryColor.Central, TerritoryColor.JustWestOfCentral);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory.CalculateWhichTerritoryColorTwoDifferentTerritoryColorsAreNot(TerritoryColor.JustWestOfCentral, TerritoryColor.JustEastOfCentral);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory.CalculateWhichTerritoryColorTwoDifferentTerritoryColorsAreNot(TerritoryColor.JustWestOfCentral, TerritoryColor.Central);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory.CalculateWhichTerritoryColorTwoDifferentTerritoryColorsAreNot(TerritoryColor.JustEastOfCentral, TerritoryColor.JustWestOfCentral);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory.CalculateWhichTerritoryColorTwoDifferentTerritoryColorsAreNot(TerritoryColor.JustEastOfCentral, TerritoryColor.Central);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
        }

        [TestMethod]
        public void may_return_colors_for_territories_not_on_every_third_ring()
        {
            Territory territory = new Territory(7);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(8);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(9);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(10);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(11);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(12);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(13);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(14);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(15);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(16);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(17);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(18);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(37);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(38);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(39);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(40);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(41);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(42);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(43);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(44);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(45);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(46);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(47);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(48);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(49);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(50);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(51);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(52);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(53);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(54);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(55);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(56);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(57);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(58);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(59);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(60);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
        }

        [TestMethod]
        public void may_return_colors_for_territories_on_every_third_ring()
        {
            Territory territory = new Territory(19);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(20);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(21);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(22);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(23);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(24);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(25);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(26);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(27);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(28);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(29);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(30);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(31);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(32);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(33);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(34);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(35);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(36);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(91);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(92);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(93);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(94);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(95);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(96);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(97);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(98);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(99);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(100);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(101);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(102);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(103);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(104);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(105);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(106);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(107);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(108);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(109);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(110);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(111);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(112);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(113);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(114);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(115);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(116);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(117);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(118);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(119);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(120);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(121);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(122);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(123);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
            territory = new Territory(124);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustEastOfCentral);
            territory = new Territory(125);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.JustWestOfCentral);
            territory = new Territory(126);
            Assert.AreEqual(territory.territoryColor, TerritoryColor.Central);
        }

        [TestMethod]
        public void property_accessors_for_Territory_work()
        {
            Territory territory = new Territory();
            territory.hexagon = 8;
            territory.ring = 3;
            territory.ringSegment = RingSegment.EastByNortheast;
            territory.innerRing = 2;
            territory.outerRing = 4;
            territory.hexagonToTheEast = null;
            territory.hexagonToTheSouthBySoutheast = null;
            territory.hexagonToTheSouthBySouthwest = 9;
            territory.hexagonToTheWest = 1;
            territory.hexagonToTheNorthByNorthwest = 7;
            territory.hexagonToTheNorthByNortheast = null;
            territory.atBeginningOfRingSegment = false;
            territory.atEndOfRingSegment = true;
            territory.depthIntoRingSegment = 2;
            territory.beginningOfAdjacentInnerRingSegment = 1;
            territory.beginningOfAdjacentOuterRingSegment = 19;

            Assert.AreEqual(territory.hexagon, 8);
            Assert.AreEqual(territory.ring, 3);
            Assert.AreEqual(territory.ringSegment, RingSegment.EastByNortheast);
            Assert.AreEqual(Convert.ToInt32(territory.ringSegment), 1);
            Assert.AreEqual(territory.innerRing, 2);
            Assert.AreEqual(territory.outerRing, 4);
            Assert.AreEqual(territory.hexagonToTheEast, null);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, null);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 9);
            Assert.AreEqual(territory.hexagonToTheWest, 1);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 7);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, null);
            Assert.AreEqual(territory.atBeginningOfRingSegment, false);
            Assert.AreEqual(territory.atEndOfRingSegment, true);
            Assert.AreEqual(territory.depthIntoRingSegment, 2);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, 1);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, 19);

            territory.hexagonToTheEast = 21;
            territory.hexagonToTheSouthBySoutheast = 22;
            territory.hexagonToTheNorthByNortheast = 20;

            Assert.AreEqual(territory.hexagonToTheEast, 21);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 22);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 20);
        }

        [TestMethod]
        public void property_accessors_for_Territory_zero_work()
        {
            Territory territory = new Territory(0);

            Assert.AreEqual(territory.hexagon, 0);
            Assert.AreEqual(territory.ring, 0);
            Assert.AreEqual(territory.ringSegment, null);
            Assert.AreEqual(Convert.ToInt32(territory.ringSegment), 0);
            Assert.AreEqual(territory.innerRing, null);
            Assert.AreEqual(territory.outerRing, 1);
            Assert.AreEqual(territory.hexagonToTheEast, 1);
            Assert.AreEqual(territory.hexagonToTheSouthBySoutheast, 2);
            Assert.AreEqual(territory.hexagonToTheSouthBySouthwest, 3);
            Assert.AreEqual(territory.hexagonToTheWest, 4);
            Assert.AreEqual(territory.hexagonToTheNorthByNorthwest, 5);
            Assert.AreEqual(territory.hexagonToTheNorthByNortheast, 6);
            Assert.AreEqual(territory.atBeginningOfRingSegment, null);
            Assert.AreEqual(territory.atEndOfRingSegment, null);
            Assert.AreEqual(territory.depthIntoRingSegment, null);
            Assert.AreEqual(territory.beginningOfAdjacentInnerRingSegment, null);
            Assert.AreEqual(territory.beginningOfAdjacentOuterRingSegment, null);
        }

        [TestMethod]
        public void Territory_can_identify_two_oldest_neighbors()
        {
            Territory territory = new Territory(2);
            Int32[] twoOldestNeighbors = territory.returnTwoOldestNeighbors();
            Assert.AreEqual(twoOldestNeighbors[0], 0);
            Assert.AreEqual(twoOldestNeighbors[1], 1);

            territory = new Territory(22);
            twoOldestNeighbors = territory.returnTwoOldestNeighbors();
            Assert.AreEqual(twoOldestNeighbors[0], 8);
            Assert.AreEqual(twoOldestNeighbors[1], 9);

            territory = new Territory(30);
            twoOldestNeighbors = territory.returnTwoOldestNeighbors();
            Assert.AreEqual(twoOldestNeighbors[0], 14);
            Assert.AreEqual(twoOldestNeighbors[1], 29);

            territory = new Territory(77);
            twoOldestNeighbors = territory.returnTwoOldestNeighbors();
            Assert.AreEqual(twoOldestNeighbors[0], 49);
            Assert.AreEqual(twoOldestNeighbors[1], 50);
        }
    }
}