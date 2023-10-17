using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExerciseLinq
{
    public class House
    {
        public enum Type
        {
            Villa,
            Bungalow,
            Farm,
            Cottage
        }

        public string Name { get; set; }
        public string Region { get; set; }
        public decimal Price { get; set; }
        public int BedroomCount { get; set; }
        public decimal Squaremeter { get; set; }
        public Type TypeBuilding { get; set; }

    }

}

