using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffs();
        }
    }
    void DisplayStaffs()
    {
            //create instance of class
            clsStaffCollection Staffs = new clsStaffCollection();
            //set the data source to  list of staff in the collection
            lstStaffList.DataSource = Staffs.StaffList;
            //set name of primary key
            lstStaffList.DataValueField = "Staff_Id";
            //set the data field to display
            lstStaffList.DataTextField = "Staff_Name";
            //bind the data tp the list
            lstStaffList.DataBind();

    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Staff_Id"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffMDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 Staff_Id;
        //if a record has been selected from the list
        if(lstStaffList.SelectedIndex != -1){
            //get the primary key value of the record to edit
            Staff_Id = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["Staff_Id"] = Staff_Id;
            //redirect to the edit page
            Response.Redirect("StaffMDataEntry.aspx");
        }
        else//if no record has been selected
        {
            lblError.Text = "Please Select a record from the list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 Staff_Id;
        //if a record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            Staff_Id = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["Staff_Id"] = Staff_Id;
            //redirect to the delete page
            Response.Redirect("StaffMConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}