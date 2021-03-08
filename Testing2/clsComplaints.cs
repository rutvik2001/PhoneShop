using System;

namespace Testing2
{
    public class clsComplaints
    {
        public bool Active { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public string CustomerFullName { get; internal set; }
        public int CustomerID { get; internal set; }
        public int ComplaintsID { get; internal set; }
        public string ComplaintDescription { get; internal set; }
    }
}