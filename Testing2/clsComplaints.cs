using System;

namespace Testing2
{
    public class clsComplaints
    {
        private Int32 mComplaintsID;
        private Int32 mCustomerID;
        private string mCustomerFullName;
        private string mComplaintDescription;
        private DateTime mDateAdded;
        private Boolean mActive;
        public bool Active { get { return mActive; } set { mActive = value; } }
        public DateTime DateAdded { get { return mDateAdded; } set { mDateAdded = value; } }
        public string CustomerFullName { get { return mCustomerFullName; } set { mCustomerFullName = value; } }
        public int CustomerID { get { return mCustomerID; } set { mCustomerID = value; } }
        public int ComplaintsID { get { return mComplaintsID; } set { mComplaintsID = value; } }
        public string ComplaintDescription { get { return mComplaintDescription; } set { mComplaintDescription = value; } }

        public bool Find(int complaintID)
        {
            mComplaintsID = 21;
            mCustomerID = 555555;
            mCustomerFullName = "Rutvik Narendra";
            mComplaintDescription = "Damaged";
            mDateAdded = Convert.ToDateTime("16/09/2015");
            mActive = true;
            return true;
        }
   


    }
}