namespace HouseExerciseLinq
{
    internal class Program
    {
        private static List<House> houses = new List<House>();
        static void Main(string[] args)
        {
            CreateData();
            ShowFilteredData();
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
                Price = 320000,
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
                Name = "MyFirstHouse",
                Region = "Brussels",
                Price = 300000,
                BedroomCount = 2,
                Squaremeter = 100,
                TypeBuilding = House.Type.Cottage
            });
        }

    }

}