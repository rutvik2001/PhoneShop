using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsComplaint AComplaint = new clsComplaint();
        AComplaint.ComplaintsID = txtComplaintsID.Text;
 
        AComplaint.CustomerID = txtCustomerID.Text;
 
        AComplaint.CustomerFullName = txtCustomerFullName.Text;

        AComplaint.ComplaintDate = txtComplaintDate.Text;

        AComplaint.ComplaintDescription = txtComplaintDescription.Text;
   
        AComplaint.IssueSolved = chkIssueSolved.Text;
        Session["AComplaint"] = AComplaint;
        Response.Redirect("ComplaintsViewer.aspx");
    }



   
}