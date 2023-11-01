using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassModels
{
    public enum ApprovedStatus{Approved, Not_Approved, Pending};
    public enum Booking_Status { Available ,Not_Available, Pending};

    public enum Current_Status {Open, close };

    public class TravelRequest
    {
        public int RequestId { get; set; }
        public int Emp_Id { get; set; }
       // public string Emp_Name { get; set; }
        public DateTime RequestDate { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public Current_Status current_Status { get; set; }
        
        //public string IsApproved { set; get; }
        public ApprovedStatus  approved_Status{ get; set; }
        public Booking_Status booking_Status { get; set; }


        public override string ToString()
        {
            return String.Format("{0,-10} {1, -10} {2, -25}{3, -20}{4, -20}{5, -15}{6, -15} {7, -15} ", RequestId, Emp_Id, RequestDate, FromLocation, ToLocation, current_Status, approved_Status, booking_Status);
        }
    }
}
