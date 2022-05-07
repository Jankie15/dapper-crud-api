using PracticaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCRUDAPI.InterfaceDataAccess
{
    public interface IReadDataAccess<CustomerModel> where CustomerModel : class
    {
        Task<IEnumerable<CustomerModel>> GetAll(int Offset, int Limit);

        Task<CustomerModel> GetById(Guid id);
    }
}
