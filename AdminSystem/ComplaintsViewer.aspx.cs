using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsComplaint AComplaint = new clsComplaint();
        AComplaint = (clsComplaint) Session["AComplaint"];
        Response.Write(AComplaint.ComplaintsID);

    
        Response.Write(AComplaint.CustomerID);
        Response.Write(AComplaint.CustomerFullName);
        Response.Write(AComplaint.ComplaintDate);
        Response.Write(AComplaint.ComplaintDescription);
        Response.Write(AComplaint.IssueSolved);
    }
}