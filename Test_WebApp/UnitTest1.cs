using System;
using System.Collections.Generic;
using Core_MasGlobal;
using Core_MasGlobal.Entities;
using Data_MasGlobal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services_MasGlobal;

namespace Test_WebApp
{
    [TestClass]
    public class UnitTest1
    {
        IEmployessService employeeService;
        public UnitTest1()
        {
            employeeService = new EmployessService(new CalculatorFactory(),
                                    new DataManager());
        }
        [TestMethod]
        public void TestGetAllEmployees()
        {
            var res = employeeService.GetAllEmployees();
            List<EmployeDTO> results = new List<EmployeDTO>(res);
            Assert.AreEqual(2, results.Count);
        }

        [TestMethod]
        public void TestGetEmployee1()
        {
            var res = employeeService.GetSingleEmployee(1);
            Assert.AreEqual(1, res.Id);
        }

        [TestMethod]
        public void TestGetEmployee2()
        {
            var res = employeeService.GetSingleEmployee(2);
            Assert.AreEqual(2, res.Id);
        }

        [TestMethod]
        public void TestGetEmployeeNotExists()
        {
            var res = employeeService.GetSingleEmployee(3);
            Assert.AreEqual(null, res);
        }

        [TestMethod]
        public void TestCalculatorHour()
        {
            CalculatorFactory factory = new CalculatorFactory();
            var calculator = factory.Build("HOURLYSALARYEMPLOYEE");
            var result = calculator.Calculate(new Employe { HourlySalary = 30 });

            Assert.AreEqual(43200, result);
        }

        [TestMethod]
        public void TestCalculatorMonth()
        {
            CalculatorFactory factory = new CalculatorFactory();
            var calculator = factory.Build("MONTHLYSALARYEMPLOYEE");
            var result = calculator.Calculate(new Employe { MonthlySalary = 30 });

            Assert.AreEqual(360, result);
        }
    }
}
