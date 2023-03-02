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
       clsCustomer customerEmail = new clsCustomer();
       //capture the email
       customerEmail.Email = txtEmail.Text;
       //store the  email address in the session object
       Session["Email"] = customerEmail;
       //navigate to the viewer page
       Response.Redirect("CustomerPViewer.aspx");

        clsCustomer customerPassword = new clsCustomer();
        //capture the Password
        customerPassword.Password = txtPassword.Text;
        //store the Password in the session object
        Session["Password"] = customerPassword;
        //navigate to the viewer page
        Response.Redirect("CustomerPViewer.aspx");

           clsCustomer customerDateOfBirth = new clsCustomer();
           //capture DateOfBirth
           customerDateOfBirth.DateAdded = Convert.ToDateTime(txtDateOfBirth.Text);
           //store the DateOfBirth in the session object
           Session["DateOfBirth"] = customerDateOfBirth;
           //navigate to the viewer page
           Response.Redirect("CustomerPViewer.aspx");

        clsCustomer customerContactNumber = new clsCustomer();
        //capture the ContactNumber
        customerContactNumber.ContactNumber = txtContactNumber.Text;
        //store the ContactNumber in the session object
        Session["ContactNumber"] = customerContactNumber;
        //navigate to the viewer page
        Response.Redirect("CustomerPViewer.aspx");

        clsCustomer customerAddress = new clsCustomer();
           //capture the customerAddress
           customerAddress.Address = txtAddress.Text;
           //store the address in the session object
           Session["Address"] = customerAddress;
           //navigate to the viewer page
           Response.Redirect("CustomerPViewer.aspx");

        clsCustomer customerActive = new clsCustomer();
        //capture the customer activity status
        customerActive.Active = chkActive.Checked;
        //store the activity status in the session object
        Session["Active"] = customerActive;
        //navigate to the viewer page
        Response.Redirect("CustomerPViewer.aspx");

    }
}