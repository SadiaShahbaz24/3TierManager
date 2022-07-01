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
    public partial class Courses : System.Web.UI.Page
    {
        DataBLL dBLL = new DataBLL();
        CouData dc = new CouData();
        DataTable dtable = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            dc.Id = txtid.Text;
            dtable = dBLL.CouSearchBLL(dc);
            if (dtable.Rows.Count > 0)
            {
                result.Text = "Found successfully";
            }
            else
            {
                result.Text = "Error in search";
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dc.Id = txtid.Text;
            dc.Name= ddCourse.SelectedValue.ToString();
            dc.CrHour = ddCredit.SelectedValue.ToString();
            dc.Type = ddType.SelectedValue.ToString();
            dc.Dept = txtdeptId.Text;
            if (dBLL.CouUpdateBLL(dc))
            {
                result.Text = "Updated successfully";
            }
            else
            {
                result.Text = "Error in updation";
            }

            LoadGridView();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dc.Id = txtid.Text;
            if (dBLL.CouDeleteBLL(dc))
            {
                result.Text = "Deleted successfully";
            }
            else
            {
                result.Text = "Error in deletion";
            }
            LoadGridView();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            dc.Id = txtid.Text;
            dc.Name = ddCourse.SelectedValue.ToString();
            dc.CrHour = ddCredit.SelectedValue.ToString();
            dc.Type = ddType.SelectedValue.ToString();
            dc.Dept = txtdeptId.Text;
            if (dBLL.CouInsertBLL(dc))
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
            GridViewCourse.DataSource = dBLL.CouGetAllBLL();
            GridViewCourse.DataBind();
        }
    }
}