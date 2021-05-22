using ResortProjectAPI.ModelEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResortProjectAPI.IServices
{
    interface IRoomService
    {
        Task<IEnumerable<Room>> GetAll();

        Task<Room> GetByID(string id);

        Task<int> Create(Room room);

        Task<int> Update(Room room);

        Task<int> Delete(string id);
    }
}
