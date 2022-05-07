using DapperCRUDAPI.InterfaceDataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PracticaTecnica.DataAccess.User;
using PracticaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCRUDAPI.Extensions
{
    public static class ServiceCollectionExtension
    {
       public static void AddDependencyInjectionDataAccess(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddTransient<IReadDataAccess<CustomerModel>, CustomerDataAccess>();
            service.AddTransient<IWriteDataAccess<CustomerModel>, CustomerDataAccess>();
        }
    }
}
