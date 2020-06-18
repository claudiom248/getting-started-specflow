namespace GettingStartedSpecflow
{
    public class OhmsLawCalculator
    {
        public double Voltage { get; set; }

        public double Current { get; set; }

        public double Resistance { get; set; }

        public double CalculateVoltage()
        {
            return Current * Resistance;
        }

        public double CalculateCurrent()
        {
            return Voltage / Resistance;
        }

        public double CalculateResistance()
        {
            return Voltage / Current;
        }
    }
}
