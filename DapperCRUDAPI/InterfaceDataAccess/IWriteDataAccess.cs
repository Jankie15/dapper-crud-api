using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCRUDAPI.InterfaceDataAccess
{
    public interface IWriteDataAccess<CustomerModel> where CustomerModel : class
    {
        Task Add(CustomerModel user);

        Task Delete(Guid id);
    }
}
