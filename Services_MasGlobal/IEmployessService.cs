using Core_MasGlobal.Entities;
using System.Collections.Generic;

namespace Services_MasGlobal
{
    public interface IEmployessService
    {
        IEnumerable<EmployeDTO> GetAllEmployees();
        EmployeDTO GetSingleEmployee(int employeeId);
    }
}
