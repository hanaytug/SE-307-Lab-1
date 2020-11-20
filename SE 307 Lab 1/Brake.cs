using System;

namespace SE_307_Lab_1
{
    public class Brake
    {
        private string _type;

        public Brake(string type)
        {
            _type = type;
        }

        public void Apply()
        {
            Console.WriteLine("Car brakes applied.");
        }
    }
}
