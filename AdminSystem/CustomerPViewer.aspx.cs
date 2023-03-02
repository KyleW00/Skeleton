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
        //create a new instance of clsAddress
        clsCustomer customerEmail = new clsCustomer();
        //get the data from the session object
        customerEmail = (clsCustomer) Session["Email"];
        //display the email for this entry
        Response.Write(customerEmail.Email);

        clsCustomer customerPassword = new clsCustomer();
        //get the data from the session object
        customerPassword = (clsCustomer) Session["Password"];
        //display the Password for this entry
        Response.Write(customerPassword.Password);
       

         clsCustomer customerDateOfBirth = new clsCustomer();
         //get the data from the session object
         customerDateOfBirth = (clsCustomer)Session["DateOfBirth"];
         //display the Password for this entry
         Response.Write(customerDateOfBirth.DateAdded);

         clsCustomer customerContactNumber = new clsCustomer();
         //get the data from the session object
         customerContactNumber = (clsCustomer)Session["ContactNumber"];
         //display the Password for this entry
         Response.Write(customerContactNumber.ContactNumber);
        

        clsCustomer customerAddress = new clsCustomer();
        //get the data from the session object
        customerAddress = (clsCustomer)Session["Address"];
        //display the password for this entry
        Response.Write(customerAddress.Address);

        clsCustomer customerActive = new clsCustomer();
        //get the data from the session object
        customerActive = (clsCustomer)Session["Active"];
        //display the active status for this entry
        Response.Write(customerActive.Address);

    }
}