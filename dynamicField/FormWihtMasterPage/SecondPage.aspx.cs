using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Diagnostics;

namespace dynamicField.FormWihtMasterPage
{
    public partial class SecondPage : System.Web.UI.Page
    {
        System.Diagnostics.Stopwatch StopWatch = new System.Diagnostics.Stopwatch();
        //static int milisec = 0, sec = 0, min = 0, hrs = 0, day = 0;       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["milisec"] = 0;
                Session["sec"] = 0;
                Session["min"] = 0;
                Session["hrs"] = 0;
                Session["day"] = 0;
                createDataTable();
                Session["SortedView"] = null;
                bind1();
            }
        }

        public void encoding()
        {
            byte[] name = System.Text.Encoding.UTF32.GetBytes("sunil");
            string endName = Convert.ToBase64String(name);
        }

        public void deconding()
        {
            string name = System.Text.Encoding.UTF32.GetString(Convert.FromBase64String("cwAAAHUAAABuAAAAaQAAAGwAAAA="));
        }

        public DataTable createDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("Mob", typeof(string));
            dt.Columns.Add("Add", typeof(string));

            for (int i = 0; i < 50; i++)
            {
                DataRow dr = dt.NewRow();
                dr["name"] = "name" + i;
                dr["Mob"] = "mob" + i;
                dr["Add"] = "add" + i;
                dt.Rows.Add(dr);
            }

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Mob", typeof(string));
            dt1.Columns.Add("Add", typeof(string));
            dt1.Columns.Add("name", typeof(string));
            dt1.Columns.Add("name2", typeof(string));

            for (int i = 0; i < 5; i++)
            {
                DataRow dr1 = dt1.NewRow();
                dr1["name"] = "name0" + i;
                dr1["name2"] = "name20" + i;
                dr1["Mob"] = "mob0" + i;
                dr1["Add"] = "add0" + i;
                dt1.Rows.Add(dr1);
            }

            //dt.Merge(dt1);
            //dt.AcceptChanges();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            int p = dt1.Columns.Count;
            string[] columnName = new string[p];
            int k = 0;
            foreach (DataColumn dc in dt.Columns)
            {
                string column = dc.ColumnName;
                foreach (DataColumn dc1 in dt1.Columns)
                {
                    string column1 = dc1.ColumnName;

                    if (column1 == column)
                    {
                        //dt2.Columns.Add(column);

                        //for (int i = 0; i < dt.Rows.Count; i++)
                        //{
                        //    DataRow dr = dt2.NewRow();
                        //    dr[column] = dt.Rows[i][column];
                        //    dt2.Rows.Add(dr);
                        //}

                        //dt2 = dt.DefaultView.ToTable(true, column);
                        dt2.Merge(dt.DefaultView.ToTable(true, column));
                        columnName[k] = column;
                        k++;
                    }
                }
            }
            for (int i = 0; i < columnName.Length; i++)
            {
                if (columnName[i] == null)
                {
                    columnName = columnName.Where((source, index) => index != i).ToArray();
                }
            }

            dt3 = dt.DefaultView.ToTable(true, columnName);
            grdviewTable.DataSource = dt3;
            grdviewTable.DataBind();
            GridView1.DataSource = dt2;
            GridView1.DataBind();

            k = 0;
            return dt;
        }

        protected void grdviewTable_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdviewTable.PageIndex = e.NewPageIndex;
            if (Session["SortedView"] != null)
            {
                grdviewTable.DataSource = Session["SortedView"];
                grdviewTable.DataBind();
            }
            else
            {
                grdviewTable.DataSource = createDataTable();
                grdviewTable.DataBind();
            }
        }

        protected void grdviewTable_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortDirection = string.Empty;
            if (direction == SortDirection.Ascending)
            {
                direction = SortDirection.Descending;
                sortDirection = "Desc";
            }
            else
            {
                direction = SortDirection.Ascending;
                sortDirection = "asc";
            }
            DataView dvSort = new DataView(createDataTable());
            dvSort.Sort = e.SortExpression + " " + sortDirection;
            Session["SortedView"] = dvSort;
            grdviewTable.DataSource = dvSort;
            grdviewTable.DataBind();
        }

        public SortDirection direction
        {
            get
            {
                if (ViewState["directionState"] == null)
                {
                    ViewState["directionState"] = SortDirection.Ascending;
                }
                return (SortDirection)ViewState["directionState"];
            }
            set
            {
                ViewState["directionState"] = value;
            }
        }

        protected void btnTimerStar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        protected void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        protected void btnStop_Click(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        protected void timer1_Tick(object sender, EventArgs e)
        {
            Session["milisec"] = Convert.ToInt32(Session["milisec"]) + 1;
            if (Convert.ToInt32(Session["milisec"]) == 9)
            {
                Session["sec"] = Convert.ToInt32(Session["sec"]) + 1;
                Session["milisec"] = 0;
            }
            if (Convert.ToInt32(Session["sec"]) == 59)
            {
                Session["min"] = Convert.ToInt32(Session["min"]) + 1;
                Session["sec"] = 0;
            }
            if (Convert.ToInt32(Session["min"]) == 59)
            {
                Session["hrs"] = Convert.ToInt32(Session["hrs"]) + 1;
                Session["min"] = 0;
            }
            if (Convert.ToInt32(Session["hrs"]) == 24)
            {
                Session["day"] = Convert.ToInt32(Session["day"]) + 1;
                Session["hrs"] = 0;
            }

            lblTimer.Text = "day: " + Session["day"] + "Hrs: " + Session["hrs"] + "Min: " + Session["min"] + "Sec: " + Session["sec"] + "Milisec: " + Session["milisec"];
        }

        public void bind1(Int64 cd = 19164, string str = "select option")
        {
            try
            {
                ddltest.Items.Insert(0, new ListItem("select1", "0"));
                ddltest.Items.Insert(0,new ListItem(Convert.ToString(cd), str));
                ddltest.Items.Insert(2, "demo1");
            }
            catch(Exception ex)
            {

            }
        }

        protected void ddltest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = ddltest.SelectedValue;
            string b = ddltest.SelectedItem.Text;
        }

    }
}