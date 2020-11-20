using System;

namespace SE_307_Lab_1
{
    public class AutomatedManualTransmission : IAutomaticTransmission, IManualTransmission
    {

        private double[] _gearRatio;
        private int _currentGear;

        AutomaticTransmission automaticTransmission;
        ManualTransmission manualTransmission;
        
        public AutomatedManualTransmission(double[] gearRatio, int currentGear)
        {
            _gearRatio = gearRatio;
            _currentGear = currentGear;
            
            automaticTransmission = new AutomaticTransmission(gearRatio, currentGear);
            manualTransmission = new ManualTransmission(gearRatio, currentGear);
        }

        public void ShiftUp()
        {
            manualTransmission.ShiftUp();
        }

        public void ShiftDown()
        {
            manualTransmission.ShiftDown();
        }

        public void SetGear(int gear)
        {
            automaticTransmission.SetGear(gear);
        }

        public void Reverse()
        {
            manualTransmission.Reverse();
        }

    }
}
