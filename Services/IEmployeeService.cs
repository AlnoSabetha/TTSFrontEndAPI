using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTSfront_end.Services
{
    public interface IEmployeeService
    {
         Task<IEnumerable<Employees>> GetAll();
         Task<Employees> GetById(int id);
    }
}