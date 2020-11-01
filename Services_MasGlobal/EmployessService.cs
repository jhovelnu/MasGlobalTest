using Core_MasGlobal;
using Core_MasGlobal.Entities;
using Data_MasGlobal;
using System.Collections.Generic;
using System.Linq;

namespace Services_MasGlobal
{
    public class EmployessService : IEmployessService
    {
        private readonly CalculatorFactory _factory;
        private readonly IDataManager _data;

        public EmployessService(
            CalculatorFactory factory,
            IDataManager data)
        {
            _factory = factory;
            _data = data;
        }

        public IEnumerable<EmployeDTO> GetAllEmployees()
        {
            var employeeList = _data.GetEmployees();

            return employeeList.Select(Transform);
        }

        public EmployeDTO GetSingleEmployee(int employeeId)
        {
            var employeeList = _data.GetEmployees();

            var employee = employeeList.FirstOrDefault(e => e.Id == employeeId);
            if (employee != null)
                return Transform(employee);
            else return null;
        }

        private EmployeDTO Transform(Employe employee)
        {
            var dto = new EmployeDTO()
            {
                Id = employee.Id,
                Name = employee.Name,
                ContractType = employee.ContractType,
                RoleId = employee.RoleId,
                RoleName = employee.RoleName,
                RoleDescription = employee.RoleDescription,
            };

            var calculator = _factory.Build(dto.ContractType);
            dto.CalculatedSalary = calculator.Calculate(employee);
            return dto;
        }
    }
}
