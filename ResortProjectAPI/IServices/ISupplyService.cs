using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResortProjectAPI.ModelEF;

namespace ResortProjectAPI.IServices
{
    public interface ISupplyService
    {
        Task<IEnumerable<Supply>> GetAll();

        Task<Supply> GetByID(string id);

        Task<int> Create(Supply sup);

        Task<int> Update(Supply sup, string editType, int? count);

        Task<int> Delete(string id);
    }
}
