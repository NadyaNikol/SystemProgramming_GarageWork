using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace WFormGarage
{
    public class Truck : Car
    {
        private int cargo;
        public int Cargo
        {
            set
            {
                if (value > MaxCargo) cargo = MaxCargo;
                else if (value < 0) cargo = 0;
                else cargo = value;
            }

            get
            {
                return cargo;
            }
        }
        public int MaxCargo { set; get; }
        public Truck(int curS, int maxS, int car, int maxC) : base(curS, maxS)
        {
            Cargo = car;
            MaxCargo = maxC;
        }

        public override void Down()
        {
            Cargo -= RandomGenerator.Next(10, MaxCargo);
        }



        public override void Up()
        {
            Cargo += RandomGenerator.Next(10, MaxCargo);
        }
    }
}
