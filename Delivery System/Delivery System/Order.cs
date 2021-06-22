using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoCoordinatePortable;

namespace Delivery_System
{
    public class Order
    {
        private string number;
        private double weight;
        private DateTime? startDate;
        private DateTime? finishDate;

        public Order(string number, double weight)
        {
            this.number = number;
            this.weight = weight;
        }

        public Courier Courier { get; set; }

        public string Number => number;

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (Courier != null)
                    throw new Exception("Not change weight, if courier is assigned");

                if (value < 0)
                    throw new Exception("Incorrect weight");

                weight = value;
            }
        }

        public GeoCoordinate StartLocation { get; set; }
        public GeoCoordinate FinishLocation { get; set; }
    }
}
