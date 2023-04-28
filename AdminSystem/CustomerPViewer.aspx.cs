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
        
        clsCustomer AnCustomer = new clsCustomer();
        AnCustomer = (clsCustomer)Session["AnCustomer"];

        Response.Write(AnCustomer.CustomerID);
        Response.Write(AnCustomer.Email);
        Response.Write(AnCustomer.Password);
        Response.Write(AnCustomer.DateAdded);
        Response.Write(AnCustomer.ContactNumber);
        Response.Write(AnCustomer.Address);
        Response.Write(AnCustomer.Active);

        
    }
}