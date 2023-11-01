using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModels;

namespace DAL
{
   public class ReqDataManger : IReqDataManager
    {
        private readonly EmpDataManager _emp = new EmpDataManager();
        

        public List<TravelRequest> lstRequest = new List<TravelRequest>()
        {
           new TravelRequest(){ RequestId = 1, Emp_Id = 1, RequestDate = DateTime.Parse("20-02-2023"), FromLocation = "shrirampur", ToLocation = "pune", current_Status= Current_Status.Open, approved_Status= ApprovedStatus.Pending, booking_Status= Booking_Status.Pending},
           new TravelRequest(){ RequestId = 2, Emp_Id = 2, RequestDate = DateTime.Parse("20-02-2024"), FromLocation = "shrirampur", ToLocation = "pune", current_Status= Current_Status.close, approved_Status= ApprovedStatus.Not_Approved, booking_Status= Booking_Status.Pending},
           new TravelRequest(){ RequestId = 3, Emp_Id = 3, RequestDate = DateTime.Parse("20-02-2024"), FromLocation = "shrirampur", ToLocation = "pune", current_Status= Current_Status.close, approved_Status= ApprovedStatus.Approved, booking_Status= Booking_Status.Available},
           new TravelRequest(){ RequestId = 4, Emp_Id = 4, RequestDate = DateTime.Parse("20-02-2023"), FromLocation = "shrirampur", ToLocation = "pune", current_Status= Current_Status.Open, approved_Status= ApprovedStatus.Approved, booking_Status= Booking_Status.Pending},
           new TravelRequest(){ RequestId = 5, Emp_Id = 5, RequestDate = DateTime.Parse("20-02-2023"), FromLocation = "shrirampur", ToLocation = "pune", current_Status= Current_Status.close, approved_Status= ApprovedStatus.Approved, booking_Status= Booking_Status.Not_Available}
        };

        public void ViewRequest_DAL()
        {


            //foreach (TravelRequest e in lstRequest)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //Console.ReadLine();

            var ViewReq = from emp in _emp.lstEmployees
                          join req in lstRequest
                          on emp.Emp_Id equals req.Emp_Id
                          select new
                          {
                              ReqID = req.RequestId,
                              empID = req.Emp_Id,
                              empNAME = emp.Emp_FirstName,
                              Date = req.RequestDate,
                              From = req.FromLocation,
                              To = req.ToLocation,
                              Approved = req.approved_Status,
                              Booking = req.booking_Status,
                              Current = req.current_Status
                          };


            Console.WriteLine("*************************************************************\bList of All Travel Request****************************************************************************");

            Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", "ReqID", "empID","empNAME", "Date", "From", "To", "Approved", "Booking", "Current");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            foreach(var show in ViewReq)
            {
               // Console.WriteLine("RequestId" + "")
                Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", show.ReqID, show.empID,  show.empNAME, show.Date, show.From, show.To , show.Approved , show.Booking ,show.Current);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

           // Console.ReadLine();

        }

        public int AddRequest_DAL(int reqId, int e_Id, DateTime reqDate, string fromLocation, string toLocation, ApprovedStatus approved_Status, Booking_Status booking_Status, Current_Status current_Status)
        {
            lstRequest.Add(new TravelRequest() {RequestId=reqId, Emp_Id = e_Id,RequestDate= reqDate, FromLocation=fromLocation, ToLocation=toLocation, approved_Status=ApprovedStatus.Pending, booking_Status=Booking_Status.Pending, current_Status= Current_Status.Open});
            ViewRequest_DAL();
            return 1;
        }



        

       public int DeleteReq_DAL(int reqId)
        {
            var Delete = lstRequest.FirstOrDefault(req => req.RequestId == reqId);

            if (Delete != null)
            {
                Console.WriteLine("In Remove- {0}", Delete.RequestId);
                lstRequest.Remove(Delete);
                ViewRequest_DAL();
                return 1;
            }
            return 1;
        }


        public void GetApproveReq_DAL()
        {
            var appStatus = from emp in _emp.lstEmployees
                          join req in lstRequest
                          on emp.Emp_Id equals req.Emp_Id
                            where req.approved_Status == ApprovedStatus.Approved  && req.booking_Status == Booking_Status.Pending
                            select new
                          {
                              ReqID = req.RequestId,
                              empID = req.Emp_Id,
                              empNAME = emp.Emp_FirstName,
                              Date = req.RequestDate,
                              From = req.FromLocation,
                              To = req.ToLocation,
                              Approved = req.approved_Status,
                              Booking = req.booking_Status,
                              Current = req.current_Status
                          };
            Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", "ReqID", "empID", "empNAME", "Date", "From", "To", "Approved", "Booking", "Current");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            foreach (var show in appStatus)
            {
                // Console.WriteLine("RequestId" + "")
                Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", show.ReqID, show.empID, show.empNAME, show.Date, show.From, show.To, show.Approved, show.Booking, show.Current);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        }


        public void GetPendingApproval_DAL()
        {
            var penStatus = from emp in _emp.lstEmployees
                            join req in lstRequest
                            on emp.Emp_Id equals req.Emp_Id
                            where req.approved_Status == ApprovedStatus.Pending 
                            select new
                            {
                                ReqID = req.RequestId,
                                empID = req.Emp_Id,
                                empNAME = emp.Emp_FirstName,
                                Date = req.RequestDate,
                                From = req.FromLocation,
                                To = req.ToLocation,
                                Approved = req.approved_Status,
                                Booking = req.booking_Status,
                                Current = req.current_Status
                            };

            
          

            Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", "ReqID", "empID", "empNAME", "Date", "From", "To", "Approved", "Booking", "Current");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            foreach (var show in penStatus)
            {
                // Console.WriteLine("RequestId" + "")
                Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", show.ReqID, show.empID, show.empNAME, show.Date, show.From, show.To, show.Approved, show.Booking, show.Current);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

           // Console.ReadLine();
        }

        public void BookingReq_DAL()
        {
           

            var bookingStatus = from emp in _emp.lstEmployees
                            join req in lstRequest
                            on emp.Emp_Id equals req.Emp_Id
                            where req.booking_Status == Booking_Status.Available && req.current_Status == Current_Status.Open
                            select new
                            {
                                ReqID = req.RequestId,
                                empID = req.Emp_Id,
                                empNAME = emp.Emp_FirstName,
                                Date = req.RequestDate,
                                From = req.FromLocation,
                                To = req.ToLocation,
                                Approved = req.approved_Status,
                                Booking = req.booking_Status,
                                Current = req.current_Status
                            };

            Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", "ReqID", "empID", "empNAME", "Date", "From", "To", "Approved", "Booking", "Current");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            foreach (var show in bookingStatus)
            {
                // Console.WriteLine("RequestId" + "")
                Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", show.ReqID, show.empID, show.empNAME, show.Date, show.From, show.To, show.Approved, show.Booking, show.Current);
            
               }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ReadLine();
        }

        public int EditRequest_DAL(TravelRequest request)
        {
            TravelRequest req_main = lstRequest.FirstOrDefault(x => x.RequestId == request.RequestId);
            int index = lstRequest.IndexOf(req_main);

            lstRequest[index].Emp_Id = request.Emp_Id;//do like all for every field
            lstRequest[index].RequestDate = request.RequestDate;
            lstRequest[index].FromLocation = request.FromLocation;
            lstRequest[index].ToLocation = request.ToLocation;
            ViewRequest_DAL();
            return 1;
        }
        public TravelRequest GetRequestById_DAL(int reqId)
        {
            TravelRequest request = lstRequest.FirstOrDefault(e => e.RequestId == reqId);
            if (request != null)
            {
                return request;
            }
            return null;
        }

        public void Getclosed_DAL()
        {
            var appStatus = from emp in _emp.lstEmployees
                            join req in lstRequest
                            on emp.Emp_Id equals req.Emp_Id
                            where req.current_Status == Current_Status.close 
                            select new
                            {
                                ReqID = req.RequestId,
                                empID = req.Emp_Id,
                                empNAME = emp.Emp_FirstName,
                                Date = req.RequestDate,
                                From = req.FromLocation,
                                To = req.ToLocation,
                                Approved = req.approved_Status,
                                Booking = req.booking_Status,
                                Current = req.current_Status
                            };

            Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", "ReqID", "empID", "empNAME", "Date", "From", "To", "Approved", "Booking", "Current");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            foreach (var show in appStatus)
            {
                // Console.WriteLine("RequestId" + "")
                Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", show.ReqID, show.empID, show.empNAME, show.Date, show.From, show.To, show.Approved, show.Booking, show.Current);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ReadLine();
        }

       public void GetOpend_DAL()
        {
            var appStatus = from emp in _emp.lstEmployees
                            join req in lstRequest
                            on emp.Emp_Id equals req.Emp_Id
                            where req.approved_Status == ApprovedStatus.Pending 
                            select new
                            {
                                ReqID = req.RequestId,
                                empID = req.Emp_Id,
                                empNAME = emp.Emp_FirstName,
                                Date = req.RequestDate,
                                From = req.FromLocation,
                                To = req.ToLocation,
                                Approved = req.approved_Status,
                                Booking = req.booking_Status,
                                Current = req.current_Status
                            };


            Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", "ReqID", "empID", "empNAME", "Date", "From", "To", "Approved", "Booking", "Current");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            foreach (var show in appStatus)
            {
                // Console.WriteLine("RequestId" + "")
                Console.WriteLine("{0,-10} {1, -10} {2, -20}{3, -25}{4, -20}{5, -20}{6, -15} {7, -15} {8, -10}", show.ReqID, show.empID, show.empNAME, show.Date, show.From, show.To, show.Approved, show.Booking, show.Current);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ReadLine();
        }


    }
    

}
