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

        
        string Email = txtEmail.Text;
        string Password = txtPassword.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string ContactNumber = txtContactNumber.Text;
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
            AnCustomer.Active = chkActive.Checked;
            AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);

            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if(txtCustomerID == -1)
            {

            }


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
        //if found
        if(Found == true)
        {
            txtEmail.Text = AnCustomer.Email;
            txtPassword.Text = AnCustomer.Password;
            txtAddress.Text = AnCustomer.Address;
            txtContactNumber.Text = AnCustomer.ContactNumber;
            txtDateOfBirth.Text = AnCustomer.DateAdded.ToString();
            chkActive.Checked = AnCustomer.Active;

        }
    }

    protected void txtDateOfBirth_TextChanged(object sender, EventArgs e)
    {

    }
    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        Customers.ThisCustomer.Find(CustomerID);

        txtCustomerID.Text = Customers.ThisCustomer.CustomerID.ToString();
        txtEmail.Text = Customers.ThisCustomer.Email;
        txtPassword.Text = Customers.ThisCustomer.Password;
        txtDateOfBirth.Text = Customers.ThisCustomer.DateAdded.ToString();
        txtAddress.Text = Customers.ThisCustomer.Address;
        chkActive.Checked = Customers.ThisCustomer.Active;


    }
}