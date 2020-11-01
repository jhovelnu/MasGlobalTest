using Core_MasGlobal.Entities;
using System.Collections.Generic;

namespace Data_MasGlobal
{
    public interface IDataManager
    {
        IEnumerable<Employe> GetEmployees();
    }
}
