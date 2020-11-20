using System;

namespace SE_307_Lab_1
{
    public class ManualTransmission : GearBox, IManualTransmission
    {
        private double[] _gearRatio;
        private int _currentGear;

        public ManualTransmission(double[] gearRatio, int currentGear)
        {
            _gearRatio = gearRatio;
            _currentGear = currentGear;
        }

        public void ShiftUp()
        {
            _currentGear++;
            Console.WriteLine("Shift Up, Gear: " + _currentGear);
        }

        public void ShiftDown()
        {
            _currentGear--;
            Console.WriteLine("Shift Down, Gear: " + _currentGear);
        }

        public void Reverse()
        {
            _currentGear = 0;
            Console.WriteLine("Reverse, Gear: R");
        }
    }
}
