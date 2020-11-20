using System;

namespace SE_307_Lab_1
{
    public class AutomaticTransmission : GearBox, IAutomaticTransmission
    {
        private double[] _gearRatio;
        private int _currentGear;

        public AutomaticTransmission(double[] gearRatio, int currentGear)
        {
            _gearRatio = gearRatio;
            _currentGear = currentGear;
        }

        public void SetGear(int gear)
        {
            _currentGear = gear;
            Console.WriteLine("Gear set, Gear: " + _currentGear);
        }

        public void Reverse()
        {
            _currentGear = 0;
            Console.WriteLine("Reverse, Gear: R");
        }
    }
}
