using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff staffinfo = new clsStaff();
        //capture the StaffID
        staffinfo.Staffid = int.Parse(txtStaffID.Text);
        //store the first name in session object
        Session["staffinfo"] = staffinfo;

        //capture the FirstName
        staffinfo.Firstname = txtFirstName.Text;
        //store the first name in session object
        Session["staffinfo"] = staffinfo;

        //capture the Surname
        staffinfo.Lastname = txtSurname.Text;
        //store the Surname name in session object
        Session["staffinfo"] = staffinfo;

        //capture the DateOfBirth
        staffinfo.DOB = DateTime.Parse(txtDateOfBirth.Text);
        //store the Surname name in session object
        Session["staffinfo"] = staffinfo;

        //capture the Surname
        staffinfo.salary = double.Parse(txtMonthlySalary.Text);
        //store the Surname name in session object
        Session["staffinfo"] = staffinfo;

        //capture the Surname
        //staffinfo.Status = bool.Parse(chkMarried(true));
        //store the Surname name in session object
        //Session["staffinfo"] = staffinfo;

        //Navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStaff staffinfo = new clsStaff();
        //variable to store the primary key
        Int32 StaffID1;
        //Variable to store the result from the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID1 = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = staffinfo.Find(StaffID1);
        //if found
        if (Found == true)
        {
            txtFirstName.Text = staffinfo.Firstname;
            txtSurname.Text = staffinfo.Lastname;
            txtDateOfBirth.Text = staffinfo.DOB.ToString();
            txtMonthlySalary.Text = staffinfo.salary.ToString();
        }

    }
}