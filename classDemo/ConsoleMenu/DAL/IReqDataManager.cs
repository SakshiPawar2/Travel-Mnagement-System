using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModels;

namespace DAL
{
    public interface IReqDataManager
    {
        //int RaisedReq_DAL(int req_Id, int Emp_id, DateTime ReqDate, string From_Location, string To_Location);
       // int EditRequest_DAL(TravelRequest travelRequest);
        
      
       //int ConfirmRequest_DAL(int travel_Id, Booking_Status bookstatus);

        void ViewRequest_DAL();
        int AddRequest_DAL(int reqId, int e_Id, DateTime reqDate, string fromLocation, string toLocation, ApprovedStatus approved_Status, Booking_Status booking_Status, Current_Status current_Status);

        int DeleteReq_DAL(int reqId);

       TravelRequest GetRequestById_DAL(int reqId);

        void GetApproveReq_DAL();

        void GetPendingApproval_DAL();

        int EditRequest_DAL(TravelRequest request);

        void BookingReq_DAL();

        void Getclosed_DAL();

        void GetOpend_DAL();
    }
}
