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

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsCustomer AnCustomer = new clsCustomer();

        //capture customer email
        AnCustomer.Email = txtEmail.Text;

        //capture the Password
        AnCustomer.Password = txtPassword.Text;

        //capture DateOfBirth
        AnCustomer.DateAdded = Convert.ToDateTime(txtDateOfBirth.Text);

        //capture the ContactNumber
        AnCustomer.ContactNumber = txtContactNumber.Text;

        //capture the customerAddress
        AnCustomer.Address = txtAddress.Text;

        //capture the customer activity status
        AnCustomer.Active = Convert.ToBoolean(chkActive.Checked);

        //store the Ancustomer to the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerPViewer.aspx");
    }
}