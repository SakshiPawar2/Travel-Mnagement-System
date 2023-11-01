
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ClassModels;

namespace BAL
{
    public class Request_BAL : IRequest_BAL
    {
        private readonly ReqDataManger _travelData = new ReqDataManger();

        public void ViewRequest_BAL()
        {
            _travelData.ViewRequest_DAL();
        }

       public int AddRequest_BAL(int reqId, int e_Id, DateTime reqDate, string fromLocation, string toLocation, ApprovedStatus approved_Status, Booking_Status booking_Status, Current_Status current_Status)
        {
            _travelData.AddRequest_DAL(reqId, e_Id, reqDate, fromLocation, toLocation, approved_Status, booking_Status, current_Status);
            return 1;
        }

        public int DeleteReq_BAL(int reqId)
        {
            _travelData.DeleteReq_DAL(reqId);

            return 1;
        }

        public void GetApproveReq_BAL()
        {
            _travelData.GetApproveReq_DAL();
        }

        public void GetPendingApproval_BAL()
        {
            _travelData.GetPendingApproval_DAL();
        }

        public TravelRequest GetRequestById_BAL(int reqId)
        {
            TravelRequest req = _travelData.GetRequestById_DAL(reqId);
            return req;
        }

        public int EditRequest_BAL(TravelRequest Req_to_Change)
        {
            _travelData.EditRequest_DAL(Req_to_Change);
            return 1;
        }


       public  void Getclosed_BAL()
        {
            _travelData.Getclosed_DAL();
        }
       public void GetOpen_BAL()
        {
            _travelData.GetOpend_DAL();
        }

       public void BookinStatus_BAL()
        {
            _travelData.BookingReq_DAL();
        }



    }
}
