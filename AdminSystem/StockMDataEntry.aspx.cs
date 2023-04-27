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






    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsStock
        clsStock AStock = new clsStock();
        //capture the StockId, StockName, StockQuantity, StockCost, InStock, DateAdded
        String StockId = txtStockId.Text;
        String StockName = txtStockName.Text;
        String StockQuantity = txtStockQuantity.Text;
        String StockCost = txtStockCost.Text;
        String DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(StockId, StockQuantity, StockCost, DateAdded);
        if (Error =="")
        {
            //capture the StockId, StockName, StockQuantity, StockCost, InStock, DateAdded
            AStock.StockId = Convert.ToInt32(txtStockId.Text);
            AStock.StockName = txtStockName.Text;
            AStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
            AStock.StockCost = Convert.ToDecimal(txtStockCost.Text);
            AStock.InStock = chkInStock.Checked;
            AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //Store the Stock in the session object
            Session["AStock"] = AStock;
            //redirect to the viewer page
            Response.Redirect("StockMViewer.aspx");
        }
        else
        {
            //dispaly the error message
            lblError.Text = Error;
        }
        
        
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock class
        clsStock AStock = new clsStock();
        //variable to store the primary key
        Int32 StockId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockId = Convert.ToInt32(txtStockId.Text);
        //find the record
        Found = AStock.Find(StockId);
        //if found
        if (Found == true)
        {
            //display values of the properties in the form
            txtStockId.Text = AStock.StockName;
            txtStockName.Text = AStock.StockName;
            txtStockQuantity.Text = AStock.StockQuantity.ToString();
            txtStockCost.Text = AStock.StockCost.ToString();
            txtDateAdded.Text = AStock.DateAdded.ToString();
            chkInStock.Checked = AStock.InStock;
        }
    }
}