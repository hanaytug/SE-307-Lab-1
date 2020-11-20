using System;

namespace SE_307_Lab_1
{
    public class Wheel
    {
        private double _diameter;
        private Tire _tire;

        public Wheel(double diameter, Tire tire)
        {
            _diameter = diameter;
            _tire = tire;
        }

    }
}
