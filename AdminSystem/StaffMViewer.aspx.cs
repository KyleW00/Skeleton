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
        //create a new instance of the Staff class
        clsStaff AStaff = new clsStaff();
        //gets data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //displays a inputted data
        Response.Write(AStaff.Staff_Name);
    }
}