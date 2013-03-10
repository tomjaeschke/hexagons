using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Damisam.MathematicsCalculations.Tests
{
    [TestClass]
    public class TerritoryColorTester
    {
        public TerritoryColorTester()
        {
        }

        [TestMethod]
        public void test_numeric_values_for_TerritoryColor()
        {
            TerritoryColor territoryColor = TerritoryColor.Central;
            Assert.AreEqual(territoryColor, TerritoryColor.Central);
            Assert.AreEqual(Convert.ToInt32(territoryColor), 0);
            territoryColor = TerritoryColor.JustEastOfCentral;
            Assert.AreEqual(territoryColor, TerritoryColor.JustEastOfCentral);
            Assert.AreEqual(Convert.ToInt32(territoryColor), 1);
            territoryColor = TerritoryColor.JustWestOfCentral;
            Assert.AreEqual(territoryColor, TerritoryColor.JustWestOfCentral);
            Assert.AreEqual(Convert.ToInt32(territoryColor), 2);
        }
    }
}
