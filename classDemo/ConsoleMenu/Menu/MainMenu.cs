using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using ClassModels;

namespace Menu
{

    //enum menu { }
        public class MainMenu
        {
                 private static readonly EmployeeBAL _empManager = new EmployeeBAL();
                private static readonly Request_BAL _travelManager = new Request_BAL();


                //Show Main MEnu method
                public static void ShowMenu()
                    {

                
                    Console.Clear();
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("\t Main Menu");
                    Console.WriteLine("----------------------------");

                    String choice;

                    Console.WriteLine(" 1. Manage Employees. \n 2. Manage Travel Request. \n 3. Exit");
                    Console.WriteLine("\n Select Choice");
                    choice = Console.ReadLine();

                    switch (choice)
                    {

                        case "1":
                            //DisplayManageEmployee();
                           // Console.WriteLine("Manage Employee");
                            MainMenu.ShowEmpManagement();
                            break;//

                        case "2":
                            // DisplayManageTravelRequest();
                           // Console.WriteLine("Manage Travel Request");
                            MainMenu.ShowTravelRequest();
                            break;

                        case "3":


                            // Console.WriteLine("Exit");
                            //exit = true;
                            Environment.Exit(0);
                           break;

                        default:
                            Console.WriteLine("Invalid Choice please try again");
                            break;
                    }
                      Console.ReadLine();
        
                 }


            public static void ShowEmpManagement()
            {
                
                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("\t Manage Employees");
                Console.WriteLine("----------------------------");

                String choice;

                Console.WriteLine(" 1. Add Employee. \n 2. Edit Employee. \n 3. Delete Employee. \n 4. View All Employee \n 5. Go back \n 6.Exit");
                Console.WriteLine("\n Select Your choice");
                choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                    MainMenu.ShowAddEmployee();
                    
                        break;//
                    
                    case "2":
                    MainMenu.ShowEditEmployee();
                    Console.WriteLine("you have selected edit employee");

                        break;

                    case "3":
                       MainMenu.ShowDeleteEmployee();
                      //  Console.WriteLine("you have selected delete Employee");

                        break;

                    case "4":
                    MainMenu.ShowViewAllEmployee();
                    Console.WriteLine("press enter to go back");
                    break;
                    
                   case "5":
                    MainMenu.ShowMenu();
                    break;
                   case "6":
                    // Console.WriteLine("Exit");
                    Environment.Exit(0);
                    Console.Clear();
                    break;

                  default:
                        Console.WriteLine("Invalid Choice please try again");
                        break;
                }
              
            }

            public static void ShowTravelRequest()
            {
            Console.Clear();
                //Console.WriteLine("YOU SELECTED: MANAGE TRAVEL REQUEST");
                string choice;
                

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("\t MANAGE TRAVEL REQUEST");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine(" 1. Raise Travel Request. \n 2. Edit Ttravel Request.\n 3. Delete Travel Request. \n 4. View Travel Request. \n 5. Approved Travel Request. \n 6. Confirm Booking. \n 7. Go Back.\n 8. Exit");
                Console.WriteLine("\n Enter your choice: ");
                choice = Console.ReadLine();
               

                switch (choice)
                {
                    
                    case "1":
                    Console.Clear();
                    // Console.WriteLine("RAISE TRAVEL REQUEST");
                    MainMenu.ShowRaiseReq();
                    Console.WriteLine("press 0 to go back");
                   int i = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        Console.Clear();
                        MainMenu.ShowTravelRequest();
                    }

                    break;
                case "2":
                    Console.Clear();
                    MainMenu.ShowEditReq();
                    Console.WriteLine("if you want to edit another employee then press 0 to go back press enter");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 0)
                        MainMenu.ShowEditReq();
                    else
                        MainMenu.ShowTravelRequest();

                    Console.ReadLine();
                    break;
                    case "3":

                        MainMenu.ShowDeleteReq();
                    Console.WriteLine("press 0 to go back");
                    int j = int.Parse(Console.ReadLine());
                    if (j == 0)
                    {
                        Console.Clear();
                        MainMenu.ShowTravelRequest();
                    }
                    break;

                    case "4":
                    Console.Clear();
                    // Console.WriteLine("VIEW TRAVEL REQUEST");
                      MainMenu. ShowViewAllReq();
                    Console.WriteLine("press 0 to go back");
                      int k = int.Parse(Console.ReadLine());
                        if(k == 0)
                    {
                        Console.Clear();
                        MainMenu.ShowTravelRequest();
                    }

                    break;

                    case "5":

                    //Console.WriteLine("APPROVED TRAVEL REQUEST");
                    // MainMenu.GetPendingApproval();
                    MainMenu.Approved_Req();
                        break;

                    case "6":

                    MainMenu.ShowbookinReq();
                    break;

                case "7":
                    MainMenu.ShowMenu();
                    break;

                case "8":

                    Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice please try again");
                        break;
                }
              

            }
        public static void ShowAddEmployee()
        {

            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("\t Add Employee");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Enter Employee Id: ");
            int Emp_Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee First name : ");
            string Emp_FirstName = Console.ReadLine();

            Console.WriteLine("Enter employee last name: ");
            string Emp_LastName = Console.ReadLine();

            Console.WriteLine("Enter Employee DOB: ");
            DateTime Emp_DoB = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Address: ");
            string Emp_Address = Console.ReadLine();

            Console.WriteLine("Enter Employee Contact : ");
            string Emp_Contact = Console.ReadLine();

            _empManager.AddEmployee_BAL(Emp_Id, Emp_FirstName, Emp_LastName, Emp_DoB, Emp_Address, Emp_Contact);

            Console.WriteLine("Press 0 to add more employee otherwise press 1 to go back");
            
            int i = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                MainMenu.ShowAddEmployee();
            }
            else if (i == 1)
            {
                MainMenu.ShowEmpManagement();
            }
            else
                Environment.Exit(0);

            Console.ReadLine();
        }
        public static void ShowEditEmployee()
        {

            int e_Id;
            string e_firstName, e_lastName, e_address, e_contact;
            DateTime e_dob;

            Employees Emp_to_Change;
            String choice;

            do
            {
                

                _empManager.ViewAllEmployee_BAL();
                Console.WriteLine("\n Enter the  employee id : ");
                e_Id = int.Parse(Console.ReadLine());

                //get employee to change from BAL
                Emp_to_Change = _empManager.GetEmployeeById_BAL(e_Id);

                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("\t Edit Employee");
                Console.WriteLine("----------------------------");
               
               
                Console.WriteLine(" 1.First Name. \n 2.Last Name \n 3.DOB \n 4.Address. \n 5.Contact \n 6.goback \n 7.exit");
                Console.WriteLine("\n Select Choice");
                choice = Console.ReadLine();
       
                switch (choice)
                {

                    case "1":
                        //DisplayManageEmployee();
                        Console.WriteLine("Enter the first name: ");
                        e_firstName = Console.ReadLine();
                        Emp_to_Change.Emp_FirstName = e_firstName;
                        Console.WriteLine("press enter to edit and press 0 to go back ");
                      
                        break;

                    case "2":
                        Console.WriteLine("Enter the Last name: ");
                        e_lastName = Console.ReadLine();
                        Emp_to_Change.Emp_LastName = e_lastName;
                        break;

                    case "3":
                        Console.WriteLine("Enter the new DOB: ");
                        e_dob = DateTime.Parse(Console.ReadLine());
                        Emp_to_Change.Emp_DoB = e_dob;
                        break;

                    case "4":
                        Console.WriteLine("Enter the new address: ");
                        e_address = Console.ReadLine();
                        Emp_to_Change.Emp_Address = e_address;
                        break;

                    case "5":
                        Console.WriteLine("Enter the Contact: ");
                        e_contact = Console.ReadLine();
                        Emp_to_Change.Emp_Contact = e_contact;
                        break;

                    case "6":
                        // Console.WriteLine("Exit");
                        ShowMenu();
                        break;

                    case "7":
                        // Console.WriteLine("Exit");
                        Environment.Exit(0);
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice please try again");
                        break;
                }
            } while (choice != "5");//after while
            _empManager.EditEmployee_BAL(Emp_to_Change);
            Console.ReadLine();
        }



            public static void ShowDeleteEmployee()
            {
            _empManager.ViewAllEmployee_BAL();
            Console.WriteLine(" Enter Employee Id to delete");
            int e_Id = int.Parse(Console.ReadLine());
           
                _empManager.DeleteEmp_BAL(e_Id);
           
            Console.ReadLine();
            }
            public static void ShowViewAllEmployee()
            {
            _empManager.ViewAllEmployee_BAL();
            }
            public static void ShowRaiseReq()
            {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("\t Raise Travel Request");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Enter Request Id: ");
            int RequestId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Id: ");
            int Emp_Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Travel Date:  ");
            DateTime RequestDate =DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Location From: ");
            string FromLocation = Console.ReadLine();

            Console.WriteLine("Enter Location To : ");
            string ToLocation = Console.ReadLine();

            ApprovedStatus approved_Status = ApprovedStatus.Pending;

            Booking_Status booking_Status = Booking_Status.Pending;

            Current_Status current_Status = Current_Status.Open;

           
            _travelManager.AddRequest_BAL(RequestId, Emp_Id, RequestDate, FromLocation, ToLocation, approved_Status, booking_Status, current_Status);
        }


            public static void ShowEditReq()
            {
            int e_Id, reqId;
            string from_location, to_location;
            DateTime req_Date;

            TravelRequest Req_to_Change;
            String choice;

            do
            {

                Console.Clear();
                _travelManager.GetPendingApproval_BAL();
                 Console.WriteLine("\n Enter the  Request id : ");
                reqId = int.Parse(Console.ReadLine());

                //get employee to change from BAL
                Req_to_Change = _travelManager.GetRequestById_BAL(reqId);

                
                Console.WriteLine("----------------------------");
                Console.WriteLine("\t Edit Travel Request");
                Console.WriteLine("----------------------------");


                Console.WriteLine(" 1.Employee Id. \n 2. Date \n 3. Location From \n 4. Location To\n 5. Go Back \n 6. Exit");
                Console.WriteLine("\n Select Choice");
                choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                        //DisplayManageEmployee();
                        Console.WriteLine("Enter the Employee Id: ");
                        e_Id = int.Parse(Console.ReadLine());
                        Req_to_Change.Emp_Id = e_Id;
                        Console.WriteLine("Would you like to Continue if yes then enter y if no then enter n");
                        string a = Console.ReadLine();
                        if (a == "y")
                        {
                            ShowEditReq();
                        }
                        else if(a=="n")
                        {
                            ShowTravelRequest();
                        }
                        break;

                    case "2":
                       
                        Console.WriteLine("Enter the request Date: ");
                        req_Date = DateTime.Parse(Console.ReadLine());
                        Req_to_Change.RequestDate = req_Date;

                        Console.WriteLine("Would you like to Continue if yes then enter y if no then enter n");
                        string b = Console.ReadLine();
                        if (b == "y")
                        {
                            ShowEditReq();
                        }
                        else if (b == "n")
                        {
                            ShowTravelRequest();
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter the Location To: ");
                        from_location = Console.ReadLine();
                        Req_to_Change.FromLocation = from_location;
                        Console.WriteLine("Would you like to Continue if yes then enter y if no then enter n");
                        string c = Console.ReadLine();
                        if (c == "y")
                        {
                            ShowEditReq();
                        }
                        else if (c == "n")
                        {
                            ShowTravelRequest();
                        }
                        break;

                    case "4":
                        Console.WriteLine("Enter the Location To: ");
                        to_location = Console.ReadLine();
                        Req_to_Change.ToLocation = to_location;
                        Console.WriteLine("Would you like to Continue if yes then enter y if no then enter n");
                        string d = Console.ReadLine();
                        if (d == "y")
                        {
                            ShowEditReq();
                        }
                        else if (d == "n")
                        {
                            ShowTravelRequest();
                        }
                        break;

                    case "5":
                        ShowTravelRequest();
                        break;

                    case "6":
                        // Console.WriteLine("Exit");
                        Environment.Exit(0);
                       // Console.Clear();
                        break;


                    default:
                        Console.WriteLine("Invalid Choice please try again");
                        break;
                }
            } while (choice != "5");//after while
            _travelManager.EditRequest_BAL(Req_to_Change);
        }


            public static void ShowDeleteReq()
            {
            _travelManager.ViewRequest_BAL();
            Console.WriteLine(" Enter request Id to delete: ");
            int reqId = int.Parse(Console.ReadLine());
            _travelManager.DeleteReq_BAL(reqId);

        }

            public static void ShowViewAllReq()
            {
            //Console.WriteLine("Show All Request");
            _travelManager.ViewRequest_BAL();
        }

        public static void Approved_Req()
        {
            Console.Clear();
            _travelManager.GetPendingApproval_BAL();
            int reqId;
            TravelRequest Req_to_Change;
            Console.WriteLine("Enter the  Request id : ");
            reqId = int.Parse(Console.ReadLine());

            //get employee to change from BAL
            Req_to_Change = _travelManager.GetRequestById_BAL(reqId);
            string choice;


            Console.WriteLine("----------------------------");
            Console.WriteLine("\t Approved Travel Request");
            Console.WriteLine("----------------------------");


            Console.WriteLine(" 1.Approved. \n 2.Not-Approved \n 3.Go back \n 4.Exit");
            Console.WriteLine("\n Select Choice");
            choice = Console.ReadLine();

            switch (choice)
            {

                case "1":

                    Req_to_Change.approved_Status = ApprovedStatus.Approved;
                    Console.WriteLine("Status is Approved");
                    
                    break;

                case "2":

                    Req_to_Change.approved_Status = ApprovedStatus.Not_Approved;
                    Req_to_Change.current_Status = Current_Status.close;
                    Console.WriteLine("Status is not Approved");

                    //int c = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Press 0 to go back and press 1 to continue approved request");
                    //if (c == 0)
                    //    ShowTravelRequest();
                    //else if (c == 1)
                        //Approved_Req();
                    break;

                case "3":
                    MainMenu.Approved_Req();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                   // Console.ReadLine();
                    break;
            }
            //

            _travelManager.ViewRequest_BAL();
            Console.WriteLine("Press 0 to go back and press 1 to continue approved request");
            string b = Console.ReadLine();
            if (b == "0")
            { MainMenu.ShowTravelRequest(); }
            else if (b == "1")
            { MainMenu.Approved_Req(); }


            Console.ReadLine();
        }

       


            public static void GetApprovedReq()
            {
            //Console.WriteLine("Show Approved Request");
              _travelManager.GetApproveReq_BAL();
              Console.ReadLine();
            }

            public static void GetPendingApproval()
        {
            _travelManager.GetPendingApproval_BAL();
        }

            public static void ShowbookinReq()
        {
            Console.Clear();
            _travelManager.GetApproveReq_BAL();
            int reqId;
            TravelRequest Req_to_Change;
            Console.WriteLine("\nEnter the  Request id : ");
            reqId = int.Parse(Console.ReadLine());

            //get employee to change from BAL
            Req_to_Change = _travelManager.GetRequestById_BAL(reqId);
            string choice;


            Console.WriteLine("----------------------------");
            Console.WriteLine("\t Booking Travel Request");
            Console.WriteLine("----------------------------");


            Console.WriteLine(" 1. Available. \n 2.Not-Available \n 3.Go back \n 4.\nExit");
            Console.WriteLine("\n Select Choice");
            choice = Console.ReadLine();

            switch (choice)
            {

                case "1":

                    Req_to_Change.booking_Status  = Booking_Status.Available;
                    Req_to_Change.current_Status = Current_Status.close;
                    Console.WriteLine("Booking confirm");

                    //string a = Console.ReadLine();
                    //if (a == "y")
                    //{
                    //    ShowEditReq();
                    //}
                    //else if (a == "n")
                    //{
                    //    ShowTravelRequest();
                    //}
                    break;

                case "2":

                    Req_to_Change.booking_Status = Booking_Status.Not_Available;
                    Req_to_Change.current_Status = Current_Status.close;
                    Console.WriteLine("Status is not Approved");
                    break;

                case "3":
                    MainMenu.Approved_Req();
                    break;

                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    Console.ReadLine();
                    break;
            }
            _travelManager.ViewRequest_BAL();
            MainMenu.ShowbookinReq();
            Console.WriteLine("Press 0 to go back and press 1 to continue approved request");
            string b = Console.ReadLine();
            if (b == "0")
            { MainMenu.ShowTravelRequest(); }
            else if (b == "1")
            { MainMenu.ShowbookinReq(); }


            
            Console.ReadLine();
        }
    

            public static void ShowClosedReq()
            {
            _travelManager.Getclosed_BAL();

            }


        public static void ShowOpenReq()
        {
            _travelManager.GetOpen_BAL();

        }


    }
    }
    
