using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class Car
    {

        public delegate void EventDelegate();

        public event EventDelegate TanksIsEmpty;
        public int FuelLevel { get; set; }

        public void Drive()
        {
            if (FuelLevel == 0)
                TanksIsEmpty();
            else
            {
                FuelLevel -= 15;
            }
        }
    }
}
