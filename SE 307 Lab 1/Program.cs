using System;

namespace SE_307_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(1.8, "Diesel", 98, 5);
            
            Brake brake = new Brake("ABS");
            
            Body body = new Body(4, "Hardtops");
            
            Tire tire = new Tire(14.0, 29.0f);
            
            Wheel wheel = new Wheel(21.0, tire);
            
            Suspension suspension = new Suspension(0.4f);
            
            Car car = new Car(202020, 2020, "35 SE 307", engine, brake, body, wheel, suspension);
            
            double[] gearRatio = { 0.5 };
            
            AutomatedManualTransmission automatedManualTransmission = new AutomatedManualTransmission(gearRatio, 0);
            car.automatedManualTransmission = automatedManualTransmission;
            
            car.engine.Ignite();
            car.automatedManualTransmission.ShiftUp();
            car.MoveForward();
            car.brake.Apply();
            car.automatedManualTransmission.ShiftDown();
            car.Stop();
            car.automatedManualTransmission.Reverse();
            car.MoveBackward();
            car.brake.Apply();
            car.automatedManualTransmission.SetGear(0);
            car.Stop();
            
        }
    }
}