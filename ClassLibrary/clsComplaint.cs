using System;

namespace ClassLibrary
{
    public class clsComplaint
    {
        private Int32 mComplaintsID;
        private Int32 mCustomerID;
        private string mCustomerFullName;
        private string mComplaintDescription;
        private DateTime mComplaintDate;
        private Boolean mIssueSolved;
        public bool IssueSolved { get { return mIssueSolved; } set { mIssueSolved = value; } }
        public DateTime ComplaintDate { get { return mComplaintDate; } set { mComplaintDate = value; } }
        public string CustomerFullName { get { return mCustomerFullName; } set { mCustomerFullName = value; } }
        public int CustomerID { get { return mCustomerID; } set { mCustomerID = value; } }
        public int ComplaintsID { get { return mComplaintsID; } set { mComplaintsID = value; } }
        public string ComplaintDescription { get { return mComplaintDescription; } set { mComplaintDescription = value; } }

        public bool Find(int complaintID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ComplaintID", complaintID);
            DB.Execute("sproc_tblComplaints_FilterByComplaintID");
            if (DB.Count == 1)
            {
                mComplaintsID = Convert.ToInt32(DB.DataTable.Rows[0]["ComplaintID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerFullName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullName"]);
                mComplaintDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ComplaintDate"]);
                mComplaintDescription = Convert.ToString(DB.DataTable.Rows[0]["ComplaintDescription"]);
                mIssueSolved = Convert.ToBoolean(DB.DataTable.Rows[0]["IssueSolved"]);
              
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}