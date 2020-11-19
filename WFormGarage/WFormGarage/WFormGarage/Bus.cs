using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace WFormGarage
{
    public class Bus : Car
    {
        private int passengers;
        public int Passengers
        {
            set
            {
                if (value > MaxPassengers) passengers = MaxPassengers;
                else passengers = value;
            }

            get
            {
                return passengers;
            }

        }
        private int MaxPassengers { set; get; }
        public Bus(int curS, int maxS, int pas, int maxP) : base(curS, maxS)
        {
            Passengers = pas;
            MaxPassengers = maxP;
        }

        public override void Down()
        {
            Passengers = 0;
        }

        public override void Up()
        {
            Passengers = RandomGenerator.Next(10, MaxPassengers);
        }
    }
}
