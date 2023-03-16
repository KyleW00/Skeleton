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

    


    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create an instance of clsStock
        clsStock AStock = new clsStock();
        //capture the StockId
        AStock.StockId = txtStockId.Text;
        //store the StockId in the session object
        Session["Astock"] = AStock;
        //Navigate to the users page
        Response.Redirect("StockMViewer.aspx");
    }
}