using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_MasGlobal.Models
{
    public class EmployeesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractType { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double AnnualSalary { get; set; }        
        
    }
}
