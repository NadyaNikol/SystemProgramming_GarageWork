using System;

namespace CarLibrary
{
    public abstract class Car
    {
        protected int curSpeed;
        protected int maxSpeed;

        public Car(int curS, int maxS)
        {
            CurSpeed = curS;
            MaxSpeed = maxS;
        }
        protected int CurSpeed
        {
            get
            {
                return curSpeed;
            }
            set
            {
                if (value > MaxSpeed) curSpeed = MaxSpeed;
                else curSpeed = value;
            }
        }

        protected int MaxSpeed
        { get
            {
                return maxSpeed;
            }
            set
            {
                maxSpeed = value;
            }
        }
        abstract public void Up();
        abstract public void Down();
    }
}
