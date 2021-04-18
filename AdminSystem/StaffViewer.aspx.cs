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
        //create a new instance of clsStaff
        clsStaff staffinfo = new clsStaff();
        //get the data from the session object
        staffinfo = (clsStaff)Session["staffinfo"];
        //display the first name for this entry
        Response.Write(staffinfo.Staffid);

        //get the data from the session object
        staffinfo = (clsStaff)Session["staffinfo"];
        //display the first name for this entry
        Response.Write(staffinfo.Firstname);

        //get the data from the session object
        staffinfo = (clsStaff)Session["staffinfo"];
        //display the surname for this entry
        Response.Write(staffinfo.Lastname);

        //get the data from the session object
        staffinfo = (clsStaff)Session["staffinfo"];
        var a = staffinfo.DOB.ToString();
        DateTime date = DateTime.Parse(a);
        //display the surname for this entry
        Response.Write(date.ToString("dd/MM/yyyy"));

        //get the data from the session object
        staffinfo = (clsStaff)Session["staffinfo"];
        //display the surname for this entry
        Response.Write(staffinfo.salary);

        //get the data from the session object
        //staffinfo = (clsStaff)Session["staffinfo"];
        //display the surname for this entry
        //Response.Write(staffinfo.Status);
    }
}