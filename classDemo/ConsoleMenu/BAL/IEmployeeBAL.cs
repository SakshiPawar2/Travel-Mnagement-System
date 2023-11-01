using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModels;

namespace BAL
{
   public interface IEmployeeBAL
    {
        void ViewAllEmployee_BAL();

        int EditEmployee_BAL(Employees Emp_to_Change);

        int DeleteEmp_BAL(int e_id);
        int AddEmployee_BAL(int e_Id, string e_FirstName, string e_LastName, DateTime e_DOB, string e_Address, string e_Contact);
        Employees GetEmployeeById_BAL(int id);
    }
}
