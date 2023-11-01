using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModels;

namespace BAL
{
    interface IRequest_BAL
    {
        void ViewRequest_BAL();

        int AddRequest_BAL(int reqId, int e_Id, DateTime reqDate, string fromLocation, string toLocation, ApprovedStatus approved_Status, Booking_Status booking_Status, Current_Status current_Status);

        int DeleteReq_BAL(int reqId);

        void GetApproveReq_BAL();

        void GetPendingApproval_BAL();

        TravelRequest GetRequestById_BAL(int reqId);

        int EditRequest_BAL(TravelRequest Req_to_Change);

        void Getclosed_BAL();
        void GetOpen_BAL();

        void BookinStatus_BAL();
    }
}
