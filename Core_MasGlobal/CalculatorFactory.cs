using System;

namespace Core_MasGlobal
{
    public class CalculatorFactory
    {
        public ICalculator Build(string contractType)
        {
            switch (contractType?.ToUpper())
            {
                case "HOURLYSALARYEMPLOYEE": return new HourlyCalculator();
                case "MONTHLYSALARYEMPLOYEE": return new MonthlyCalculator();
                default:
                    throw new Exception($"Tipo de contrato no soportado: {contractType}");
            }
        }
    }
}
