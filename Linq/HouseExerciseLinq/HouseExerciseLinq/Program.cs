namespace HouseExerciseLinq
{
    internal class Program
    {
        private static List<House> houses = new List<House>();
        static void Main(string[] args)
        {
            CreateData();
            IEnumerable<string> housesPerRegion = HousesPerRegion();
            IEnumerable<string> bedroomsPerHouse = BedroomsPerHouse();
            IEnumerable<string> housesPerType = HousesPerType();
            IEnumerable<string> housesOverHundred = HousesOverHundred();
            IEnumerable<string> housesPerFiftyK = HousesPerFiftyK();
            IEnumerable<string> housesNamePriceType = HousesNamePriceType();

            ShowFilteredData(housesPerRegion);
            ShowFilteredData(bedroomsPerHouse);
            ShowFilteredData(housesPerType);
            ShowFilteredData(housesOverHundred);
            ShowFilteredData(housesPerFiftyK);
            ShowFilteredData(housesNamePriceType);

            Console.ReadLine();
        }

        static IEnumerable<string> HousesNamePriceType()
        {
            return from house in houses
                   select $"{house.Name}\t{house.Price}\t{house.TypeBuilding}";
        }

        static void ShowFilteredData(IEnumerable<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }

        static IEnumerable<string> HousesPerRegion()
        {
            return from house in houses
                   group house by house.Region into RegionHouses
                   select $"{RegionHouses.Key} {RegionHouses.Count()}".ToString();
        }

        static IEnumerable<string> BedroomsPerHouse()
        {
            return from house in houses
                   select $"{house.Name}\t{house.BedroomCount}".ToString();
        }

        static IEnumerable<string> HousesPerType()
        {
            return from house in houses
                   group house by house.TypeBuilding into TypeHouses
                   select $"{TypeHouses.Key} {TypeHouses.Count()}".ToString();
        }

        static IEnumerable<string> HousesOverHundred()
        {
            return from house in houses
                   where house.Squaremeter > 100
                   select $"{house.Name}\t{house.Squaremeter}m²".ToString();
        }

        static IEnumerable<string> HousesPerFiftyK()
        {
            return from house in houses
                   group house by Math.Floor(house.Price / 50000) into GroupedHouses
                   select $"{GroupedHouses.Key * 50000} - {(GroupedHouses.Key * 50000) + 50000 - 1}\t{GroupedHouses.Count()}";
        }


        static void CreateData()
        {
            houses.Add(new House()
            {
                Name = "MyFirstHouse",
                Region = "WestFlanders",
                Price = 244000,
                BedroomCount = 2,
                Squaremeter = 125,
                TypeBuilding = House.Type.Cottage
            });
            houses.Add(new House()
            {
                Name = "MySecondHouse",
                Region = "WestFlanders",
                Price = 340000,
                BedroomCount = 3,
                Squaremeter = 150,
                TypeBuilding = House.Type.Villa
            });
            houses.Add(new House()
            {
                Name = "MyThirdHouse",
                Region = "EastFlanders",
                Price = 355000,
                BedroomCount = 4,
                Squaremeter = 200,
                TypeBuilding = House.Type.Farm
            });
            houses.Add(new House()
            {
                Name = "MyFourthHouse",
                Region = "Brussels",
                Price = 400000,
                BedroomCount = 3,
                Squaremeter = 125,
                TypeBuilding = House.Type.Bungalow
            });
            houses.Add(new House()
            {
                Name = "MyFifthHouse",
                Region = "Brussels",
                Price = 300000,
                BedroomCount = 2,
                Squaremeter = 100,
                TypeBuilding = House.Type.Cottage
            });
            houses.Add(new House()
            {
                Name = "MySixthHouse",
                Region = "Brussels",
                Price = 350000,
                BedroomCount = 2,
                Squaremeter = 100,
                TypeBuilding = House.Type.Cottage
            });
            houses.Add(new House()
            {
                Name = "MySeventhHouse",
                Region = "Luik",
                Price = 599500,
                BedroomCount = 5,
                Squaremeter = 800,
                TypeBuilding = House.Type.Villa
            });
        }

    }

}