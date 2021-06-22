using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoCoordinatePortable;

namespace Delivery_System
{
    public class Courier
    {
        private string name;
        private string phoneNumber;
        private double maximalWeight;

        public Courier(string name, string phoneNumber, double maximalWeight)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.maximalWeight = maximalWeight;
            IsAvailable = true;
        }

        public List<Order> Orders { get; set; } = new List<Order>();

        public string Name => name;

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public double MaximalWeight
        {
            get
            {
                return maximalWeight;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Incorrect weight");
                
                maximalWeight = value;
            }
        }

        public bool IsAvailable { get; set; }

        public GeoCoordinate CurrentLocation { get; set; }
    }
}
