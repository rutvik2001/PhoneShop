using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 StaffID1;
        private string FirstName1;
        private string Surname1;
        private DateTime DOB1;
        private double Salary1;
        private Boolean Status1;

        public int Staffid { get { return StaffID1; } set { StaffID1 = value; } }
        public string Firstname { get { return FirstName1; } set { FirstName1 = value; } }
        public string Lastname { get { return Surname1; } set { Surname1 = value; } }
        public DateTime DOB { get { return DOB1; } set { DOB1 = value; } }
        public double salary { get { return Salary1; } set { Salary1 = value; } }
        public bool Status { get { return Status1; } set { Status1 = value; } }

        public bool Find(int Staffid)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Staffid", Staffid);
            DB.Execute("sproc_tblStaff_FilterByStaffid");
            if (DB.Count == 1)
            {
                StaffID1 = Convert.ToInt32(DB.DataTable.Rows[0]["@Staffid"]);
                FirstName1 = Convert.ToString(DB.DataTable.Rows[0]["@Firstname"]);
                Surname1 = Convert.ToString(DB.DataTable.Rows[0]["@Lastname"]);
                DOB1 = Convert.ToDateTime(DB.DataTable.Rows[0]["@DOB"]);
                Salary1 = Convert.ToDouble(DB.DataTable.Rows[0]["@salary"]);
                Status1 = Convert.ToBoolean(DB.DataTable.Rows[0]["@Status"]);
                return true;
            }
            else
            {
                return false;
            }

        }
        //public string Valid(string First,
                           // string Last,
                           // DateTime Dateofbirth,
                           // double Sal,
                           // bool stat)
    }
}