using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Core_MasGlobal.Entities
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonProperty("contractTypeName")]
        public string ContractType { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
    }
}
