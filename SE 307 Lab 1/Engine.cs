using System;

namespace SE_307_Lab_1
{
    public class Engine
    {
        private double _capacity;
        private string _fuelType;
        private int _horsePower;
        private int _numberOfCylinders;

        public Engine(double capacity, string fuelType, int horsePower, int numberOfCylinders)
        {
            _capacity = capacity;
            _fuelType = fuelType;
            _horsePower = horsePower;
            _numberOfCylinders = numberOfCylinders;
        }

        public void Ignite()
        {
            Console.WriteLine("Engine ignites.");
        }
    }
}
