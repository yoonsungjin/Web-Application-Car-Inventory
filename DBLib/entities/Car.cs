using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.entities
{
    public class Car
    {
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public double Mileage { get; set; }
        public string PhotoUrl { get; set; }

        public Car(int makeId, int modelId, int year, double price, double mileage, string photoUrl)
        {
            MakeId = makeId;
            ModelId = modelId;
            Year = year;
            Price = price;
            Mileage = mileage;
            PhotoUrl = photoUrl;

        }
    }
}
