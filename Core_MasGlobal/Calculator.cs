using Core_MasGlobal.Entities;

namespace Core_MasGlobal
{
    public class HourlyCalculator : ICalculator
    {
        internal HourlyCalculator() { }
        public double Calculate(Employe employe) => 120 * employe.HourlySalary * 12;
    }

    public class MonthlyCalculator : ICalculator
    {
        internal MonthlyCalculator() { }
        public double Calculate(Employe employe) => employe.MonthlySalary * 12;
    }
}
