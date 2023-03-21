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
        //create new instance of the clsStaff
        clsStaff AStaff = new clsStaff();
        //capture staff name
        AStaff.Staff_Name = txtStaff_Name.Text;
        AStaff.Staff_Id = Convert.ToInt32(txtStaff_Id.Text);
        AStaff.Staff_Role = txtStaff_Role.Text;
        AStaff.Staff_Started = Convert.ToDateTime(txtStaff_Started.Text);
        AStaff.Staff_Salary = Convert.ToDouble(txtStaff_Salary.Text);
        AStaff.Staff_Online = Convert.ToBoolean(chkStaff_Online.Text);
        //Store the staff in the session object
        Session["AStaff"] = AStaff;
        //navigate to viewer page
        Response.Redirect("StaffMViewer.aspx");
    }

    protected void txtStaff_Id_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 Staff_Id;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Staff_Id = Convert.ToInt32(txtStaff_Id.Text);
        //find the record
        Found = AStaff.Find(Staff_Id);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaff_Name.Text = AStaff.Staff_Name;
            txtStaff_Role.Text = AStaff.Staff_Role;
            txtStaff_Started.Text = AStaff.Staff_Started.ToString();
            txtStaff_Salary.Text = AStaff.Staff_Salary.ToString();
            chkStaff_Online.Checked = AStaff.Staff_Online;
        }
    }
}