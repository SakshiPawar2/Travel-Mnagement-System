using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
    public class Employees
    {
        public int Emp_Id { get; set; }
        public string Emp_FirstName { get; set; }
        public string Emp_LastName { get; set; }
        public DateTime Emp_DoB { get; set; }
        public string Emp_Address { get; set; }
        public string Emp_Contact { get; set; }


        //static void  Employee(int e_id, string  e_firstname, string e_lastname, DateTime dob, string e_address, int e_contact )
        //{
        //     EmpDataManager.Emp_Id = e_id;
        //     Emp_FirstName = e_firstname;
        //     Emp_LastName = e_lastname;
        //     Emp_DoB = dob;
        //     Emp_Address = e_address;
        //     Emp_Contact = e_contact;
        // }
        public override string ToString()
        {
            return String.Format("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20}", Emp_Id, Emp_FirstName, Emp_LastName, Emp_DoB, Emp_Address, Emp_Contact);
            
        }



    }
}
