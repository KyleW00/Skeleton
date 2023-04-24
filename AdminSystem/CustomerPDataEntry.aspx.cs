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
      
        clsCustomer AnCustomer = new clsCustomer();

        //capture customer email
        string Email = txtEmail.Text;

        //capture the Password
        string Password = txtPassword.Text;

        //capture DateOfBirth
        string DateOfBirth = txtDateOfBirth.Text;

        //capture the ContactNumber
        string ContactNumber = txtContactNumber.Text;

        //capture the customerAddress
        string Address = txtAddress.Text;

        string Error = "";

        Error = AnCustomer.Valid(Email, Password, DateOfBirth, Address, ContactNumber);
        if(Error == "")
        {
            AnCustomer.DateAdded = Convert.ToDateTime(txtDateOfBirth.Text);
            AnCustomer.Email = Email;
            AnCustomer.Password = Password;
            AnCustomer.Address = Address;
            AnCustomer.ContactNumber = ContactNumber;

            clsCustomerCollection CustomerList = new clsCustomerCollection();

            CustomerList.ThisCustomer = AnCustomer;
            CustomerList.Add();
            Response.Redirect("CustomerPList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

       
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