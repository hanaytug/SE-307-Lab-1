using System;

namespace SE_307_Lab_1
{
    public class Car
    {
        private int _registrationNumber;
        private int _year;
        private String _licenseNumber;
        
        public ManualTransmission manualTransmission;
        public AutomaticTransmission automaticTransmission;
        public AutomatedManualTransmission automatedManualTransmission;
        public Engine engine;
        public Body body;
        public Suspension suspension;
        public Tire tire;
        public Wheel wheel;
        public Brake brake;

        public Car(int registrationNumber, int year, string licenseNumber, Engine engine, Brake brake, Body body, Wheel wheel, Suspension suspension)
        {
            _registrationNumber = registrationNumber;
            _year = year;
            _licenseNumber = licenseNumber;
            
            this.engine = engine;
            this.brake = brake;
            this.body = body;
            this.wheel = wheel;
            this.suspension = suspension;
        }

        public void MoveForward()
        {
            Console.WriteLine("Car moves forward.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Car moves backward.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car turns left.");
        }

        public void TurnRight()
        {
            Console.WriteLine("Car turns right.");
        }
        
        public void Stop()
        {
            Console.WriteLine("Car stops.");
        }
    }
}
