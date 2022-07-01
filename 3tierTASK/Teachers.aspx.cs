using AppProps;
using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3tierTASK
{
    public partial class Teachers : System.Web.UI.Page
    {

        DataBLL dBLL = new DataBLL();
        TeaData dt = new TeaData();
        DataTable dtable = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //string qryse = "select * from EmployeesData ";

            //dbCon db = new dbCon();
            //DataTable dt = db.search(qryse);
            //if (dt.Rows.Count > 0)
            //{
            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();
            //}

            dt.Id1 = txtid.Text;
            dtable = dBLL.TeaSearchBLL(dt);
            if(dtable.Rows.Count >0)
            {
                result.Text = "Found successfully";
            }
            else
            {
                result.Text = "Error in search";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt.Id1 = txtid.Text;
            if (dBLL.TeaDeleteBLL(dt))
            {
                result.Text = "Deleted successfully";
            }
            else
            {
                result.Text = "Error in deletion";
            }
            LoadGridView();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt.Id1 = txtid.Text;
            dt.FirstName = txtfname.Text;
            dt.LastName = txtlname.Text;
            dt.Qualification = ddEdu.SelectedValue.ToString();
            dt.Course = ddCourse.SelectedValue.ToString();
            dt.Email = txtemail.Text;
            if (dBLL.TeaUpdateBLL(dt))
            {
                result.Text = "Updated successfully";
            }
            else
            {
                result.Text = "Error in updation";
            }

            LoadGridView();

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            dt.Id1 = txtid.Text;
            dt.FirstName = txtfname.Text;
            dt.LastName = txtlname.Text;
            dt.Qualification = ddEdu.SelectedValue.ToString();
            dt.Course= ddCourse.SelectedValue.ToString();
            dt.Email = txtemail.Text;
            if (dBLL.TeaInsertBLL(dt))
            {
                result.Text = "Inserted successfully";
            }
            else
            {
                result.Text = "Error in insertion";
            }

            LoadGridView();
        }
        public void LoadGridView()
        {
            GridViewTeacher.DataSource = dBLL.TeaGetAllBLL();
            GridViewTeacher.DataBind();
        }
    }
}