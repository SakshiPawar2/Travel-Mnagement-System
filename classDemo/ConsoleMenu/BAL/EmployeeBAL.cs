using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ClassModels;

namespace BAL
{
    public class EmployeeBAL : IEmployeeBAL
    {
       private readonly EmpDataManager _empData = new EmpDataManager();

        public int AddEmployee_BAL(int e_Id, string e_FirstName, string e_LastName, DateTime e_DOB, string e_Address, string e_Contact)
        {
            _empData.AddEmployee_DAL( e_Id, e_FirstName, e_LastName,  e_DOB, e_Address, e_Contact);

            return 1;
        }

        public void ViewAllEmployee_BAL()
        {
            

            _empData.ViewAllEmp_DAL();
        }



        public int EditEmployee_BAL(Employees Emp_to_Change)
        {
            _empData.EditEmployee_DAL( Emp_to_Change);
            return 1;
        }

        
        public int DeleteEmp_BAL(int e_id)
        {
            _empData.DeleteEmployee_DAL(e_id);
            return 1;
        }
        public Employees GetEmployeeById_BAL(int id)
        {
            Employees emp = _empData.GetEmployeesById_DAL(id);
            return emp;
        }



       
    }
}
