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
}