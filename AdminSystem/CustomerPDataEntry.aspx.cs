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
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsCustomer AnCustomer = new clsCustomer();

        //capture customer ID
        AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);

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
       // AnCustomer.Active = Convert.ToBoolean(chkActive.Checked);

        //store the Ancustomer to the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerPViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 customerID;
        Boolean Found = false;
        //get the primary key entered by the user
        customerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(customerID);
        //if founf
        if(Found == true)
        {
            //display
            txtCustomerID.Text = AnCustomer.CustomerID.ToString();
            txtEmail.Text = AnCustomer.Email;
            txtPassword.Text = AnCustomer.Password;
            txtAddress.Text = AnCustomer.Address;
            txtContactNumber.Text = AnCustomer.ContactNumber;
            txtDateOfBirth.Text = AnCustomer.DateAdded.ToString();
            chkActive.Checked = AnCustomer.Active;

        }
    }
}