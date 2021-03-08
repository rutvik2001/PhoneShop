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
        AComplaint.ComplaintsID = Convert.ToInt32(txtComplaintsID.Text) ;
 
        AComplaint.CustomerID = Convert.ToInt32(txtCustomerID.Text);
 
        AComplaint.CustomerFullName = txtCustomerFullName.Text;

        AComplaint.ComplaintDate = Convert.ToDateTime(txtComplaintDate.Text);

        AComplaint.ComplaintDescription = txtComplaintDescription.Text;
   
        AComplaint.IssueSolved = Convert.ToBoolean(chkIssueSolved.Text);
        Session["AComplaint"] = AComplaint;
        Response.Redirect("ComplaintsViewer.aspx");
    }



   
}