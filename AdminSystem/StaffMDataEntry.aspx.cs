using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 Staff_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Id to be processed
        Staff_Id = Convert.ToInt32(Session["Staff_Id"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if(Staff_Id != -1)
            {
                //display the current data for the record
                DisplayStaffs();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of the clsStaff
        clsStaff AStaff = new clsStaff();
        //capture staff Id
        string Staff_Id = txtStaff_Id.Text;
        //capture Staff name
        string Staff_Name = txtStaff_Name.Text;
        //capture Staff Role
        string Staff_Role = txtStaff_Role.Text;
        //capture Staff Started
        string Staff_Started = txtStaff_Started.Text;
        //capture Staff Salary
        string Staff_Salary = txtStaff_Salary.Text;
        //capture Staff_Online
        string Error = "";
        //validate the dat
        Error = AStaff.Valid(Staff_Name, Staff_Role, Staff_Started, Staff_Salary);
        if (Error == "")
        {
            //capture staff id
            AStaff.Staff_Id = Convert.ToInt32(Staff_Id);
            //capture staff name
            AStaff.Staff_Name = Staff_Name;
            //capture staff role
            AStaff.Staff_Role = Staff_Role;
            //capture staff started
            AStaff.Staff_Started = Convert.ToDateTime(Staff_Started);
            //capture staff salary
            AStaff.Staff_Salary = Convert.ToDouble(Staff_Salary);
            //capture staff online
            AStaff.Staff_Online = chkStaff_Online.Checked;
            //create new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e Staff_Id = -1 then add the data
            if(Staff_Id == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(Staff_Id);
                //set ThisStaff property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("StaffMList.aspx");


        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void txtStaff_Id_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 Staff_Id;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Staff_Id = Convert.ToInt32(txtStaff_Id.Text);
        //find the record
        Found = AStaff.Find(Staff_Id);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaff_Name.Text = AStaff.Staff_Name;
            txtStaff_Role.Text = AStaff.Staff_Role;
            txtStaff_Started.Text = AStaff.Staff_Started.ToString();
            txtStaff_Salary.Text = AStaff.Staff_Salary.ToString();
            chkStaff_Online.Checked = AStaff.Staff_Online;
        }
    }

    void DisplayStaffs()
    {
        //create an instance of the staff
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(Staff_Id);
        //display the data for this record
        txtStaff_Id.Text = StaffBook.ThisStaff.Staff_Id.ToString();
        txtStaff_Name.Text = StaffBook.ThisStaff.Staff_Name;
        txtStaff_Role.Text = StaffBook.ThisStaff.Staff_Role;
        txtStaff_Started.Text = StaffBook.ThisStaff.Staff_Started.ToString();
        txtStaff_Salary.Text = StaffBook.ThisStaff.Staff_Salary.ToString();
        chkStaff_Online.Checked = StaffBook.ThisStaff.Staff_Online;
    }
}