namespace GettingStartedSpecflow
{
    public class OhmsLawCalculator
    {
        public double CalculateVoltage(double current, double resistance)
        {
            return current * resistance;
        }

        public double CalculateCurrent(double voltage, double resistance)
        {
            return voltage / resistance;
        }

        public double CalculateResistance(double voltage, double current)
        {
            return voltage / current;
        }
    }
}
