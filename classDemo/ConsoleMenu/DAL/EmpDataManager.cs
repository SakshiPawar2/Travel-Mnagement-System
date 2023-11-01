using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModels;

namespace DAL
{
    public class EmpDataManager:IEmpDataManager
    {
       
  


            public List<Employees> lstEmployees = new List<Employees>()
        {
           new Employees(){ Emp_Id = 1, Emp_FirstName = "Sakshi", Emp_LastName = "Pawar", Emp_DoB = DateTime.Parse("20-02-2001"), Emp_Address = "shrirampur", Emp_Contact = "9654327971"},
         new Employees() { Emp_Id = 2, Emp_FirstName = "Sakshi", Emp_LastName = "Pawar", Emp_DoB = DateTime.Parse("20-02-2001"), Emp_Address = "shrirampur", Emp_Contact = "23456789876"},
        new Employees() {Emp_Id = 3, Emp_FirstName = "Sakshi", Emp_LastName = "Pawar", Emp_DoB = DateTime.Parse("20-02-2001"), Emp_Address = "shrirampur", Emp_Contact = "9654327971"},
        new Employees() { Emp_Id= 4, Emp_FirstName = "Sakshi", Emp_LastName = "Pawar", Emp_DoB = DateTime.Parse("20-02-2001"), Emp_Address = "shrirampur", Emp_Contact = "9654327971" },
        new Employees() { Emp_Id = 5, Emp_FirstName = "Sakshi", Emp_LastName = "Pawar", Emp_DoB = DateTime.Parse("20-02-2001"), Emp_Address = "shrirampur", Emp_Contact = "9654327971"}
        };


            public int AddEmployee_DAL(int e_Id, string e_FirstName, string e_LastName, DateTime e_DOB, string e_Address, string e_Contact)
            { 
            lstEmployees.Add(new Employees() { Emp_Id = e_Id, Emp_FirstName = e_FirstName, Emp_LastName = e_LastName, Emp_DoB = e_DOB, Emp_Address = e_Address, Emp_Contact = e_Contact });
            ViewAllEmp_DAL();
            return 1;
            }


       


        public void ViewAllEmp_DAL()
        {

           // Console.WriteLine("======================================================================================================");
            Console.WriteLine("******************************************\bList of All Employees*************************************************");
           // Console.WriteLine("================================================================================================================");

            Console.WriteLine("\n{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} {5,-20}", "Id", "FirstName", "LastName", "DOB", "Address", "Contact");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            foreach (Employees e in lstEmployees)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("================================================================================================================");
            

            //Console.ReadLine();
        }


        public int EditEmployee_DAL(Employees employees)
        {
            Employees emp_main = lstEmployees.FirstOrDefault(x => x.Emp_Id == employees.Emp_Id);
            int index = lstEmployees.IndexOf(emp_main);

            lstEmployees[index].Emp_FirstName = employees.Emp_FirstName;//do like all for every field
            lstEmployees[index].Emp_LastName = employees.Emp_LastName;
            lstEmployees[index].Emp_DoB = employees.Emp_DoB;
            lstEmployees[index].Emp_Address = employees.Emp_Address;
            lstEmployees[index].Emp_Contact = employees.Emp_Contact;
            ViewAllEmp_DAL();
            return 1;
        }

       public Employees GetEmployeesById_DAL(int emp_Id)
        {
            Employees employee = lstEmployees.FirstOrDefault(e => e.Emp_Id == emp_Id);
            if(employee != null)
            {
                return employee;
            }
            return null;
        }

        public int DeleteEmployee_DAL(int e_id)
        {
            //Console.WriteLine("in delete-DAL");
            //ViewAllEmp_DAL();
            //Console.WriteLine(" this  {0} is deleted from list", e_id);

            // var Delete = lstEmployees.Remove(lstEmployees.FirstOrDefault(emp => emp.Emp_Id == e_id));

            var Delete = lstEmployees.FirstOrDefault(emp => emp.Emp_Id == e_id);

            if (Delete != null) 
            {
                Console.WriteLine("In Remove- {0}", Delete.Emp_FirstName);
                lstEmployees.Remove(Delete);
                ViewAllEmp_DAL();
                return 1;
            }
            return 1;
        }

    }
}
   
