using System;

namespace Damisam.MathematicsCalculations
{
    public class Territory
    {
        public int hexagon { get; set; }
        public int ring { get; set; }
        public RingSegment? ringSegment { get; set; }
        public int? innerRing { get; set; }
        public int? outerRing { get; set; }
        public int? hexagonToTheEast { get; set; }
        public int? hexagonToTheSouthBySoutheast { get; set; }
        public int? hexagonToTheSouthBySouthwest { get; set; }
        public int? hexagonToTheWest { get; set; }
        public int? hexagonToTheNorthByNorthwest { get; set; }
        public int? hexagonToTheNorthByNortheast { get; set; }
        public bool? atBeginningOfRingSegment { get; set; }
        public bool? atEndOfRingSegment { get; set; }
        public int? depthIntoRingSegment { get; set; }
        public int? beginningOfAdjacentInnerRingSegment { get; set; }
        public int? beginningOfAdjacentOuterRingSegment { get; set; }
        public TerritoryColor? territoryColor { get; set; }

        public Territory()
        {
        }

        public Territory(int positionOnSpiral)
        {
            PrepareTerritory(positionOnSpiral, true);
        }

        public Territory(int positionOnSpiral, bool isCurrentHexagon)
        {
            PrepareTerritory(positionOnSpiral, isCurrentHexagon);
        }

        public void PrepareTerritory(int positionOnSpiral, bool isCurrentHexagon)
        {
            territoryColor = null;
            hexagon = positionOnSpiral;
            ring = CalculateRing();
            outerRing = CalculateOuterRing();
            if (ring > 0)
            {
                innerRing = CalculateInnerRing();
                SetRingSegment();
                CalculateFiveNavigationCrutches();
                switch (ringSegment)
                {
                    case RingSegment.EastByNortheast:
                        FindNeighboringTerritoriesGivenEastByNortheastRingSegment();
                        break;
                    case RingSegment.EastBySoutheast:
                        FindNeighboringTerritoriesGivenEastBySoutheastRingSegment();
                        break;
                    case RingSegment.South:
                        FindNeighboringTerritoriesGivenSouthRingSegment();
                        break;
                    case RingSegment.WestBySouthwest:
                        FindNeighboringTerritoriesGivenWestBySouthwestRingSegment();
                        break;
                    case RingSegment.WestByNorthwest:
                        FindNeighboringTerritoriesGivenWestByNorthwestRingSegment();
                        break;
                    case RingSegment.North:
                        FindNeighboringTerritoriesGivenNorthRingSegment();
                        break;
                    default:
                        break;
                }
            } else {
                ringSegment = null;
                innerRing = null;
                hexagonToTheEast = 1;
                hexagonToTheSouthBySoutheast = 2;
                hexagonToTheSouthBySouthwest = 3;
                hexagonToTheWest = 4;
                hexagonToTheNorthByNorthwest = 5;
                hexagonToTheNorthByNortheast = 6;
                atBeginningOfRingSegment = null;
                atEndOfRingSegment = null;
                depthIntoRingSegment = null;
                beginningOfAdjacentInnerRingSegment = null;
                beginningOfAdjacentOuterRingSegment = null;
                territoryColor = TerritoryColor.Central;
            }
            if (ring < 2)
            {
                if (hexagon == 1 || hexagon == 3 || hexagon == 5)
                {
                    territoryColor = TerritoryColor.JustEastOfCentral;
                }
                if (hexagon == 2 || hexagon == 4 || hexagon == 6)
                {
                    territoryColor = TerritoryColor.JustWestOfCentral;
                }
            } else {
                CalculateTerritoryColor(isCurrentHexagon);
            }
        }

        public Int32[] returnTwoOldestNeighbors()
        {
            Int32 neighborToTheWest = (hexagonToTheWest != null) ? Convert.ToInt32(hexagonToTheWest) : hexagon;
            Int32 neighborToTheNorthByNorthwest = (hexagonToTheNorthByNorthwest != null) ? Convert.ToInt32(hexagonToTheNorthByNorthwest) : hexagon;
            Int32 neighborToTheNorthByNortheast = (hexagonToTheNorthByNortheast != null) ? Convert.ToInt32(hexagonToTheNorthByNortheast) : hexagon;
            Int32 neighborToTheEast = (hexagonToTheEast != null) ? Convert.ToInt32(hexagonToTheEast) : hexagon;
            Int32 neighborToTheSouthBySoutheast = (hexagonToTheSouthBySoutheast != null) ? Convert.ToInt32(hexagonToTheSouthBySoutheast) : hexagon;
            Int32 neighborToTheSouthBySouthwest = (hexagonToTheSouthBySouthwest != null) ? Convert.ToInt32(hexagonToTheSouthBySouthwest) : hexagon;
            Int32[] sixNeighbors = new Int32[] { neighborToTheWest, neighborToTheNorthByNorthwest, neighborToTheNorthByNortheast, neighborToTheEast, neighborToTheSouthBySoutheast, neighborToTheSouthBySouthwest };
            Array.Sort(sixNeighbors);
            return new Int32[] {sixNeighbors[0], sixNeighbors[1]};
        }

        public TerritoryColor? AttemptToReturnTerritoryColorForTerritoryOnRingDivisibleByThree()
        {
            if (ring % 3 == 0)
            {
                if (ringSegment == RingSegment.EastByNortheast || ringSegment == RingSegment.South || ringSegment == RingSegment.WestByNorthwest)
                {
                    if ((int)depthIntoRingSegment % 3 == 0) return TerritoryColor.Central;
                    if ((int)depthIntoRingSegment % 3 == 1) return TerritoryColor.JustWestOfCentral;
                    if ((int)depthIntoRingSegment % 3 == 2) return TerritoryColor.JustEastOfCentral;
                }
                if (ringSegment == RingSegment.EastBySoutheast || ringSegment == RingSegment.WestBySouthwest || ringSegment == RingSegment.North)
                {
                    if ((int)depthIntoRingSegment % 3 == 0) return TerritoryColor.Central;
                    if ((int)depthIntoRingSegment % 3 == 1) return TerritoryColor.JustEastOfCentral;
                    if ((int)depthIntoRingSegment % 3 == 2) return TerritoryColor.JustWestOfCentral;
                }
            }
            return null;
        }

        public void CalculateFiveNavigationCrutches()
        {
            int endOfRing = CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(ring) * 6;
            beginningOfAdjacentOuterRingSegment = endOfRing + 1 + ((Convert.ToInt32(ringSegment) - 1) * outerRing);
            int endOfInnerRing = CalculateHexagonsInInnerRingsWithoutHexagonZero();
            if (ring == 1) {
                beginningOfAdjacentInnerRingSegment = 0;
            } else {
                int endOfRingInsideInnerRing = endOfInnerRing - (Convert.ToInt32(innerRing) * 6);
                beginningOfAdjacentInnerRingSegment = endOfRingInsideInnerRing + 1 + ((Convert.ToInt32(ringSegment) - 1) * innerRing);
            }
            int hexagonsBeforeRingSegmentOnRing = (Convert.ToInt32(ringSegment) - 1) * ring;
            int hexagonsBeforeRingSegment = endOfInnerRing + hexagonsBeforeRingSegmentOnRing;
            depthIntoRingSegment = hexagon - hexagonsBeforeRingSegment;
            if (depthIntoRingSegment == 1) {
                atBeginningOfRingSegment = true;
            } else {
                atBeginningOfRingSegment = false;
            }
            if (depthIntoRingSegment == ring) {
                atEndOfRingSegment = true;
            } else {
                atEndOfRingSegment = false;
            }
        }

        public int CalculateHexagonsInInnerRingsWithoutHexagonZero()
        {
            if (innerRing > 0)
            {
                return CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(Convert.ToInt32(innerRing))*6;
            } else {
                return 0;
            }
        }

        public int? CalculateInnerRing()
        {
            if (ring > 0)
            {
                return ring - 1;
            } else {
                return null;
            }
        }

        public int CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(int rows)
        {
            int slightOffsetFromSquaring = rows*(rows + 1);
            return slightOffsetFromSquaring/2;
        }

        public int CalculateOuterRing()
        {
            return ring + 1;
        }
        
        public int CalculateRing()
        {
            int roundedSixthOfHexagon = DivideHexagonBySixWhileRoundingUp();
            return DetermineRowInBowlingBallPinArrangementForGivenPin(roundedSixthOfHexagon);
        }

        public void CalculateTerritoryColor(bool isCurrentHexagon)
        {
            territoryColor = AttemptToReturnTerritoryColorForTerritoryOnRingDivisibleByThree();
            if (isCurrentHexagon && territoryColor == null)
            {
                TryToDetermineTerritoryColorsBasedUponNeighbors();
                if (territoryColor == null)
                {
                    if (ringSegment == RingSegment.EastByNortheast || ringSegment == RingSegment.South || ringSegment == RingSegment.WestByNorthwest)
                    {
                        territoryColor = TerritoryColor.JustEastOfCentral;
                    }
                    if (ringSegment == RingSegment.EastBySoutheast || ringSegment == RingSegment.WestBySouthwest || ringSegment == RingSegment.North)
                    {
                        territoryColor = TerritoryColor.JustWestOfCentral;
                    }
                }
            }
        }

        public void CalculateWhichTerritoryColorTwoDifferentTerritoryColorsAreNot(TerritoryColor firstColor, TerritoryColor secondColor)
        {
            if (firstColor == TerritoryColor.JustEastOfCentral && secondColor == TerritoryColor.JustWestOfCentral) territoryColor = TerritoryColor.Central;
            if (firstColor == TerritoryColor.JustEastOfCentral && secondColor == TerritoryColor.Central) territoryColor = TerritoryColor.JustWestOfCentral;
            if (firstColor == TerritoryColor.JustWestOfCentral && secondColor == TerritoryColor.JustEastOfCentral) territoryColor = TerritoryColor.Central;
            if (firstColor == TerritoryColor.JustWestOfCentral && secondColor == TerritoryColor.Central) territoryColor = TerritoryColor.JustEastOfCentral;
            if (firstColor == TerritoryColor.Central && secondColor == TerritoryColor.JustEastOfCentral) territoryColor = TerritoryColor.JustWestOfCentral;
            if (firstColor == TerritoryColor.Central && secondColor == TerritoryColor.JustWestOfCentral) territoryColor = TerritoryColor.JustEastOfCentral;
        }

        public int DetermineRowInBowlingBallPinArrangementForGivenPin(int pinPosition)
        {
            decimal squareRootOfTwicePinPosition = Convert.ToDecimal(Math.Sqrt(pinPosition * 2));
            int roundingOfSquareRootOfTwicePinPosition = Convert.ToInt32(Math.Floor(squareRootOfTwicePinPosition));
            if (CalculateItemCountInBowlingBallPinArrangementGivenNumberOfRowsInArrangement(roundingOfSquareRootOfTwicePinPosition) < pinPosition)
            {
                return roundingOfSquareRootOfTwicePinPosition + 1;
            } else {
                return roundingOfSquareRootOfTwicePinPosition;
            }
        }

        public int DivideHexagonBySixWhileRoundingUp()
        {
            decimal positionOnSpiral = Convert.ToDecimal(hexagon);
            decimal divisionOfPositionOnSpiralBySix = Math.Floor(positionOnSpiral / 6);
            if (divisionOfPositionOnSpiralBySix < positionOnSpiral / 6) divisionOfPositionOnSpiralBySix = divisionOfPositionOnSpiralBySix + 1;
            return Convert.ToInt32(Math.Round(divisionOfPositionOnSpiralBySix));
        }

        public void FindNeighboringTerritoriesGivenEastByNortheastRingSegment()
        {
            hexagonToTheEast = beginningOfAdjacentOuterRingSegment + depthIntoRingSegment;
            hexagonToTheNorthByNortheast = beginningOfAdjacentOuterRingSegment + (depthIntoRingSegment - 1);
            if (atBeginningOfRingSegment == true) {
                hexagonToTheWest = hexagon - 1;
                hexagonToTheNorthByNorthwest = beginningOfAdjacentOuterRingSegment - 1;
            } else {
                hexagonToTheWest = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 2);
                hexagonToTheNorthByNorthwest = hexagon - 1;
            }
            if (atEndOfRingSegment == true)
            {
                hexagonToTheSouthBySoutheast = beginningOfAdjacentOuterRingSegment + outerRing;
                hexagonToTheSouthBySouthwest = hexagon + 1;
            } else {
                hexagonToTheSouthBySoutheast = hexagon + 1;
                hexagonToTheSouthBySouthwest = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 1);
            }
        }

        public void FindNeighboringTerritoriesGivenEastBySoutheastRingSegment()
        {
            hexagonToTheEast = beginningOfAdjacentOuterRingSegment + (depthIntoRingSegment - 1);
            hexagonToTheSouthBySoutheast = beginningOfAdjacentOuterRingSegment + depthIntoRingSegment;
            hexagonToTheNorthByNortheast = hexagon - 1;
            if (ring == 1) {
                hexagonToTheNorthByNorthwest = 0;
            } else {
                hexagonToTheNorthByNorthwest = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 2);
            }
            if (atEndOfRingSegment == true) {
                hexagonToTheSouthBySouthwest = beginningOfAdjacentOuterRingSegment + outerRing;
                hexagonToTheWest = hexagon + 1;
            } else {
                hexagonToTheSouthBySouthwest = hexagon + 1;
                hexagonToTheWest = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 1);
            }
        }

        public void FindNeighboringTerritoriesGivenNorthRingSegment()
        {
            hexagonToTheEast = hexagon + 1;
            hexagonToTheWest = hexagon - 1;
            hexagonToTheNorthByNorthwest = beginningOfAdjacentOuterRingSegment + (depthIntoRingSegment - 1);
            hexagonToTheNorthByNortheast = beginningOfAdjacentOuterRingSegment + depthIntoRingSegment;
            if (ring == 1) {
                hexagonToTheSouthBySouthwest = 0;
            } else {
                hexagonToTheSouthBySouthwest = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 2);
            }
            if (atEndOfRingSegment == true) {
                hexagonToTheSouthBySoutheast = (hexagon + 1) - (ring * 6);
            } else {
                hexagonToTheSouthBySoutheast = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 1);
            }
        }

        public void FindNeighboringTerritoriesGivenSouthRingSegment()
        {
            hexagonToTheEast = hexagon - 1;
            hexagonToTheSouthBySoutheast = beginningOfAdjacentOuterRingSegment + (depthIntoRingSegment - 1);
            hexagonToTheSouthBySouthwest = beginningOfAdjacentOuterRingSegment + depthIntoRingSegment;
            if (ring == 1) {
                hexagonToTheNorthByNortheast = 0;
            } else {
                hexagonToTheNorthByNortheast = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 2);
            }
            if (atEndOfRingSegment == true) {
                hexagonToTheWest = beginningOfAdjacentOuterRingSegment + outerRing;
                hexagonToTheNorthByNorthwest = hexagon + 1;
            } else {
                hexagonToTheWest = hexagon + 1;
                hexagonToTheNorthByNorthwest = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 1);
            }
        }

        public void FindNeighboringTerritoriesGivenWestByNorthwestRingSegment()
        {
            hexagonToTheSouthBySouthwest = hexagon - 1;
            hexagonToTheWest = beginningOfAdjacentOuterRingSegment + (depthIntoRingSegment - 1);
            hexagonToTheNorthByNorthwest = beginningOfAdjacentOuterRingSegment + depthIntoRingSegment;
            if (ring == 1) {
                hexagonToTheSouthBySoutheast = 0;
            } else {
                hexagonToTheSouthBySoutheast = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 2);
            }
            if (atEndOfRingSegment == true) {
                hexagonToTheEast = hexagon + 1;
                hexagonToTheNorthByNortheast = beginningOfAdjacentOuterRingSegment + outerRing;
            } else {
                hexagonToTheEast = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 1);
                hexagonToTheNorthByNortheast = hexagon + 1;
            }
        }

        public void FindNeighboringTerritoriesGivenWestBySouthwestRingSegment()
        {
            hexagonToTheSouthBySoutheast = hexagon - 1;
            hexagonToTheSouthBySouthwest = beginningOfAdjacentOuterRingSegment + (depthIntoRingSegment - 1);
            hexagonToTheWest = beginningOfAdjacentOuterRingSegment + depthIntoRingSegment;
            if (ring == 1) {
                hexagonToTheEast = 0;
            } else {
                hexagonToTheEast = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 2);
            }
            if (atEndOfRingSegment == true) {
                hexagonToTheNorthByNorthwest = beginningOfAdjacentOuterRingSegment + outerRing;
                hexagonToTheNorthByNortheast = hexagon + 1;
            } else {
                hexagonToTheNorthByNorthwest = hexagon + 1;
                hexagonToTheNorthByNortheast = beginningOfAdjacentInnerRingSegment + (depthIntoRingSegment - 1);
            }
        }

        public void SetRingSegment()
        {
            ringSegment = null;
            int hexagonsInLowerRingsWithoutHexagonZero = CalculateHexagonsInInnerRingsWithoutHexagonZero();
            int hexagonsInCurrentRing = ring * 6;
            int hexagonsInLowerRingsAndCurrentRingWithoutHexagonZero = hexagonsInLowerRingsWithoutHexagonZero + hexagonsInCurrentRing;
            int lastHexagonBeforeCurrentRing = hexagonsInLowerRingsAndCurrentRingWithoutHexagonZero - hexagonsInCurrentRing;
            int hexagonMinusLastHexagonBeforeCurrentRing = hexagon - lastHexagonBeforeCurrentRing;
            if (hexagon > 0)
            {
                if (hexagonMinusLastHexagonBeforeCurrentRing <= ring)
                {
                    ringSegment = RingSegment.EastByNortheast;
                } else {
                    if (hexagonMinusLastHexagonBeforeCurrentRing <= ring * 2)
                    {
                        ringSegment = RingSegment.EastBySoutheast;
                    } else {
                        if (hexagonMinusLastHexagonBeforeCurrentRing <= ring * 3)
                        {
                            ringSegment = RingSegment.South;
                        } else {
                            if (hexagonMinusLastHexagonBeforeCurrentRing <= ring * 4)
                            {
                                ringSegment = RingSegment.WestBySouthwest;
                            } else {
                                if (hexagonMinusLastHexagonBeforeCurrentRing <= ring * 5)
                                {
                                    ringSegment = RingSegment.WestByNorthwest;
                                } else {
                                    if (hexagonMinusLastHexagonBeforeCurrentRing <= ring * 6)
                                    {
                                        ringSegment = RingSegment.North;
                                    }
                                }
                            }
                        }
                    }
                }  
            }
        }

        public void TryToDetermineTerritoryColorsBasedUponNeighbors()
        {
            TerritoryColor? firstNeighborTerritoryColor = null;
            Territory referenceTerritory = new Territory((int)hexagonToTheEast, false);
            if (referenceTerritory.territoryColor != null) firstNeighborTerritoryColor = referenceTerritory.territoryColor;
            referenceTerritory = new Territory((int)hexagonToTheSouthBySouthwest, false);
            if (referenceTerritory.territoryColor != null) firstNeighborTerritoryColor = referenceTerritory.territoryColor;
            referenceTerritory = new Territory((int)hexagonToTheNorthByNorthwest, false);
            if (referenceTerritory.territoryColor != null) firstNeighborTerritoryColor = referenceTerritory.territoryColor;

            TerritoryColor? secondNeighborTerritoryColor = null;
            referenceTerritory = new Territory((int)hexagonToTheSouthBySoutheast, false);
            if (referenceTerritory.territoryColor != null) secondNeighborTerritoryColor = referenceTerritory.territoryColor;
            referenceTerritory = new Territory((int)hexagonToTheWest, false);
            if (referenceTerritory.territoryColor != null) secondNeighborTerritoryColor = referenceTerritory.territoryColor;
            referenceTerritory = new Territory((int)hexagonToTheNorthByNortheast, false);
            if (referenceTerritory.territoryColor != null) secondNeighborTerritoryColor = referenceTerritory.territoryColor;

            if (firstNeighborTerritoryColor != null && secondNeighborTerritoryColor != null)
            {
                CalculateWhichTerritoryColorTwoDifferentTerritoryColorsAreNot((TerritoryColor) firstNeighborTerritoryColor, (TerritoryColor) secondNeighborTerritoryColor);
            }
        }
    }
}