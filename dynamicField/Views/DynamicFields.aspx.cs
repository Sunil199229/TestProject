using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace dynamicField.Views
{
    public partial class DynamicFields : System.Web.UI.Page
    {
        protected static List<object> lstitm;
        protected TextBox tx;
        protected DropDownList ddl;

        protected string[] name;
        protected string[] value;
        protected string[] checkBoxName;
        protected string[] checkBoxValue;
        protected string[] ddlName;
        protected string[] ddlValue;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstitm = new List<object>();
                lstitm.Add(new ListItem(text: "a", value: "1"));
                lstitm.Add(new ListItem(text: "b", value: "2"));
                lstitm.Add(new ListItem(text: "c", value: "3"));
                lstitm.Add(new ListItem(text: "d", value: "4"));
                lstitm.Add(new ListItem(text: "e", value: "5"));
                lstitm.Add(new ListItem(text: "f", value: "6"));
            }

            if (Convert.ToString(ViewState["Generated"]) == "true")
                generateControls();
        }

        private void chkbx_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void chkboxlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(ViewState["Generated"]) != "true")
            {
                generateControls();
                ViewState["Generated"] = "true";
            }        
            
        }

        public void generateControls()
        {
            for (int i = 0; i < chkboxlist.Items.Count; i++)
            {
                if (chkboxlist.Items[i].Selected == true)
                {
                    tx = new TextBox();
                    tx.ID = "txtName" + chkboxlist.Items[i].Value;
                    pnl.Controls.Add(tx);
                    //form1.Controls.Add(tx);

                    ddl = new DropDownList();
                    ddl.ID = "ddlAlpha" + chkboxlist.Items[i].Value;
                    ddl.AppendDataBoundItems = true;
                    ddl.Items.Insert(0,new ListItem("select","0"));
                    ddl.DataSource = lstitm;
                    ddl.DataTextField = "text";
                    ddl.DataValueField = "value";
                    ddl.DataBind();
                    ddl.SelectedIndexChanged += new EventHandler(ddlAlpha_SelectedIndexChanged);
                    ddl.AutoPostBack = true;
                    pnl.Controls.Add(ddl);
                    //form1.Controls.Add(ddl);
                    
                }
            }
        }

        protected void ddlAlpha_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //name = new string[10];
            //value = new string[10];
            List<string> strname = new List<string>();
            List<string> strvalue = new List<string>();
            List<string> strCheckBoxName = new List<string>();
            List<string> strCheckBoxID = new List<string>();
            List<string> strDdlName = new List<string>();
            List<string> strDdlID = new List<string>();
            for (int i = 0; i < chkboxlist.Items.Count; i++)
            {
                if (chkboxlist.Items[i].Selected == true)
                {
                    strCheckBoxName.Add(chkboxlist.Items[i].Text);
                    strCheckBoxID.Add(chkboxlist.Items[i].Value);
                }
            }
            foreach (TextBox item in pnl.Controls.OfType<TextBox>())
            {
                strname.Add(item.Text);
                strvalue.Add(item.ID);
            }

            foreach (DropDownList item in pnl.Controls.OfType<DropDownList>())
            {
                strDdlName.Add(item.SelectedItem.Text);
                strDdlID.Add(item.SelectedValue);
            }

            name = strname.ToArray();
            value = strvalue.ToArray();
            checkBoxName = strCheckBoxName.ToArray();
            checkBoxValue = strCheckBoxID.ToArray();
            ddlName = strDdlName.ToArray();
            ddlValue = strDdlID.ToArray();

            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("checkBoxName", typeof(string));
            dt.Columns.Add("checkBoxValue", typeof(string));
            dt.Columns.Add("ddlName", typeof(string));
            dt.Columns.Add("ddlValue", typeof(string));
                       
            for (int i = 0; i < name.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr["name"] = name[i];
                dr["checkBoxName"] = checkBoxName[i];
                dr["checkBoxValue"] = checkBoxValue[i];
                dr["ddlName"] = ddlName[i];
                dr["ddlValue"] = ddlValue[i];

                dt.Rows.Add(dr);
            }
           
        }
    }
}