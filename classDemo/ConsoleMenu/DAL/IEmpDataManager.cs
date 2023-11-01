using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModels;

namespace DAL
{
    public interface IEmpDataManager 
    {
        int AddEmployee_DAL(int e_Id, string e_FirstName, string e_LastName, DateTime e_DOB, string e_Address, string e_Contact);
        int EditEmployee_DAL(Employees employees);
        int DeleteEmployee_DAL(int e_id);

        void ViewAllEmp_DAL();

        Employees GetEmployeesById_DAL(int id);
        
    }
}
