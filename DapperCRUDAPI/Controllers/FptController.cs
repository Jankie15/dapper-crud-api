using DapperCRUDAPI.InterfaceDataAccess;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaTecnica.DataAccess.User;
using PracticaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCRUDAPI.Controllers
{   [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class FptController : ControllerBase
    {       
        private readonly IReadDataAccess<CustomerModel> _IReadDataAccess;
        private readonly IWriteDataAccess<CustomerModel> _IWriteDataAccess;

        public FptController(IReadDataAccess<CustomerModel> IReadDataAccess, IWriteDataAccess<CustomerModel> IWriteDataAccess)
        {           
            _IReadDataAccess = IReadDataAccess;
            _IWriteDataAccess = IWriteDataAccess;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerModel>> Get(int Offset, int Limit)
        {
            IEnumerable<CustomerModel> result = await _IReadDataAccess.GetAll(Offset, Limit);
            return result;
        }

        [HttpGet("{id}")]
        public async Task<CustomerModel> Get(Guid id)
        {
            CustomerModel result = await _IReadDataAccess.GetById(id);
            return result;
        }

        [HttpPost]
        public async Task Post([FromBody] CustomerModel user)
        {
            if (ModelState.IsValid)
            {
               await _IWriteDataAccess.Add(user);
            }
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _IWriteDataAccess.Delete(id);
        }
    }
}
