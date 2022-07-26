using ADOCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Services
{
    interface ICompanyService
    {
        List<tblemployee> GetEmployees();
        tblemployee GetEmployeeByID(int id);
        void AddEmployee(tblemployee obj);
        void UpdateEmployee(tblemployee obj);
        void DeleteEmployee(int id);
    }
}
