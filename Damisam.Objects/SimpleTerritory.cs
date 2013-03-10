using Damisam.MathematicsCalculations;

namespace Damisam.Objects
{
    public class SimpleTerritory
    {
        public int Hexagon { get; private set; }
        public int HexagonToTheEast { get; private set; }
        public int HexagonToTheSouthBySoutheast { get; private set; }
        public int HexagonToTheSouthBySouthwest { get; private set; }
        public int HexagonToTheWest { get; private set; }
        public int HexagonToTheNorthByNorthwest { get; private set; }
        public int HexagonToTheNorthByNortheast { get; private set; }

        public string Color { get; private set; }
        public string ColorOfHexagonToTheEast { get; private set; }
        public string ColorOfHexagonToTheSouthBySoutheast { get; private set; }
        public string ColorOfHexagonToTheSouthBySouthwest { get; private set; }
        public string ColorOfHexagonToTheWest { get; private set; }
        public string ColorOfHexagonToTheNorthByNorthwest { get; private set; }
        public string ColorOfHexagonToTheNorthByNortheast { get; private set; }

        public SimpleTerritory(int positionOnSpiral)
        {
            Territory territory = new Territory(positionOnSpiral);
            Hexagon = territory.hexagon;
            HexagonToTheEast = (int)territory.hexagonToTheEast;
            HexagonToTheSouthBySoutheast = (int)territory.hexagonToTheSouthBySoutheast;
            HexagonToTheSouthBySouthwest = (int)territory.hexagonToTheSouthBySouthwest;
            HexagonToTheWest = (int)territory.hexagonToTheWest;
            HexagonToTheNorthByNorthwest = (int)territory.hexagonToTheNorthByNorthwest;
            HexagonToTheNorthByNortheast = (int)territory.hexagonToTheNorthByNortheast;
            Color = CalculateColor(territory);
            ColorOfHexagonToTheEast = CalculateColor(new Territory((int)territory.hexagonToTheEast));
            ColorOfHexagonToTheSouthBySoutheast = CalculateColor(new Territory((int)territory.hexagonToTheSouthBySoutheast));
            ColorOfHexagonToTheSouthBySouthwest = CalculateColor(new Territory((int)territory.hexagonToTheSouthBySouthwest));
            ColorOfHexagonToTheWest = CalculateColor(new Territory((int)territory.hexagonToTheWest));
            ColorOfHexagonToTheNorthByNorthwest = CalculateColor(new Territory((int)territory.hexagonToTheNorthByNorthwest));
            ColorOfHexagonToTheNorthByNortheast = CalculateColor(new Territory((int)territory.hexagonToTheNorthByNortheast));
        }

        private string CalculateColor(Territory territory)
        {
            string color = "bitter"; //should never stay bitter
            if (territory.territoryColor == TerritoryColor.Central) color = "sweet";
            if (territory.territoryColor == TerritoryColor.JustEastOfCentral) color = "sour";
            if (territory.territoryColor == TerritoryColor.JustWestOfCentral) color = "salty";
            return color;
        }
    }
}