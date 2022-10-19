//using LoginSystem.App_Code.PL;
//using LoginSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dynamicField.FormWihtMasterPage
{
    public partial class GridViewUpdatePanelTrigger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtChallandate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                DDL();
            }
            //this.RegisterPostBackControl();            
        }

        //private void RegisterPostBackControl()
        //{
        //    foreach (GridViewRow row in GridView1.Rows)
        //    {
        //        Button lnkFull = row.FindControl("btnview") as Button;
        //        ScriptManager.GetCurrent(this).RegisterPostBackControl(lnkFull);
        //    }
        //}

        public void DDL()//For Bind Revenue Head and Zone
        {
            try
            {
                //PL_ApplicantRegister pl = new PL_ApplicantRegister();
                //pl.Ind = 1;
                //string url = string.Format("ApplicantRegister/BindZone");
                DataTable DSDDLS = new DataTable();
                //DSDDLS = Comman.ApiPostDataSet(url, pl);
                DSDDLS.Columns.Add("DocumentName");
                DSDDLS.Columns.Add("DocumentId");
                DSDDLS.Columns.Add("Compulsory");   
                for (int i = 0; i < 3; i++)
                {
                    DataRow dr = DSDDLS.NewRow();
                    dr["DocumentName"] = "a" + i;
                    dr["DocumentId"] = "b" + i;
                    dr["Compulsory"] = "c" + i;

                    DSDDLS.Rows.Add(dr);
                }
                if (DSDDLS != null)
                {
                    if (DSDDLS.Rows.Count > 0)
                    {
                        GridView1.DataSource = DSDDLS;
                        GridView1.DataBind();
                    }

                    //if (DSDDLS.Tables[1].Rows.Count > 0)
                    //{
                    //    ddlZone.Items.Clear();
                    //    ddlZone.DataSource = DSDDLS.Tables[1];
                    //    ddlZone.DataTextField = "ZoneNo";
                    //    ddlZone.DataValueField = "ZoneId";
                    //    ddlZone.DataBind();
                    //    ddlZone.Items.Insert(0, new ListItem("--Select--", "0"));
                    //}

                    //if (DSDDLS.Tables[2].Rows.Count > 0)
                    //{
                    //    ddlPetType.Items.Clear();
                    //    ddlPetType.DataSource = DSDDLS.Tables[2];
                    //    ddlPetType.DataTextField = "PetName";
                    //    ddlPetType.DataValueField = "PetId";
                    //    ddlPetType.DataBind();
                    //    ddlPetType.Items.Insert(0, new ListItem("--Select--", "0"));
                    //}

                }
            }
            catch (Exception ex)
            {
                //ShowMessage(ex.Message, false);
            }
        }

        //protected void ddlZone_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (ddlZone.SelectedValue != "0")
        //        {
        //            PL_ApplicantRegister objpl = new PL_ApplicantRegister();
        //            objpl.Ind = 2;
        //            objpl.ZoneNo = Convert.ToInt32(ddlZone.SelectedItem.Text);
        //            string url = string.Format("ApplicantRegister/BindWard");
        //            DataTable dt = new DataTable();
        //            dt = Comman.ApiPostDataTable(url, objpl);
        //            if (dt != null && dt.Rows.Count > 0)
        //            {
        //                ddlward.Items.Clear();
        //                ddlward.DataSource = dt;
        //                ddlward.DataTextField = "WardNumber";
        //                ddlward.DataValueField = "WardId";
        //                ddlward.DataBind();
        //                ddlward.Items.Insert(0, new ListItem("--Select--", "0"));
        //            }
        //        }
        //        else
        //        {
        //            ddlward.Items.Clear();
        //            ddlward.Items.Insert(0, new ListItem("--Select--", "0"));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowMessage("Something went wrong, try again", false);
        //    }
        //}

        //protected void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SaveDocument();
        //        PL_ApplicantRegister objpl = new PL_ApplicantRegister();
        //        objpl.Ind = 3;
        //        objpl.ZoneNo = Convert.ToInt32(ddlZone.SelectedItem.Text);
        //        objpl.Ward = Convert.ToInt32(ddlward.SelectedItem.Text);
        //        objpl.ApplicantName = txtapplicantName.Text.Trim().ToUpper();
        //        objpl.FatherName = txtfathername.Text.Trim().ToUpper();
        //        objpl.MobileNo = txtphoneno.Text;
        //        objpl.ApplicantAddress = txtaddress.Text.Trim().ToUpper();
        //        objpl.PetType = ddlPetType.SelectedItem.Text;
        //        objpl.PetName = txtPetName.Text.Trim().ToUpper();
        //        objpl.PetDOB = Convert.ToDateTime(TxtDOBdate.Text);
        //        objpl.Breed = TxtBreed.Text.Trim().ToUpper();
        //        objpl.Color = TxtColor.Text.Trim().ToUpper();
        //        objpl.Mark = Txtmark.Text.Trim().ToUpper();
        //        objpl.PetGender = ddlgender.SelectedItem.Text;
        //        objpl.VaccinationDetail = TxtVacdetails.Text.Trim().ToUpper();
        //        objpl.SterilizationDetails = TxtSterilizDet.Text.Trim().ToUpper();
        //        objpl.EntryDate = DateTime.Now;
        //        objpl.AllDocument = (DataTable)ViewState["Document"];
        //        string url = string.Format("ApplicantRegister/ApplicantEntry");
        //        DataTable dt = new DataTable();
        //        dt = Comman.ApiPostDataTable(url, objpl);
        //        if (dt != null && dt.Rows[0]["result"].ToString() == "1")
        //        {
        //            ShowMessage("Record Save Successful.", true);
        //            Clear();
        //        }
        //        {
        //            ShowMessage(dt.Rows[0]["Msg"].ToString(), false);
        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        void Clear()
        {
            txtaddress.Text = string.Empty;
            ddlZone.ClearSelection();
            ddlward.ClearSelection();
            txtapplicantName.Text = string.Empty;
            txtfathername.Text = string.Empty;
            txtphoneno.Text = string.Empty;
            ddlPetType.ClearSelection();
            txtPetName.Text = string.Empty;
            TxtDOBdate.Text = string.Empty;
            TxtBreed.Text = string.Empty;
            TxtColor.Text = string.Empty;
            Txtmark.Text = string.Empty;
            ddlgender.ClearSelection();
            TxtVacdetails.Text = string.Empty;
            TxtSterilizDet.Text = string.Empty;
        }

        void ShowMessage(string Message, bool type)
        {
            try
            {
                lblMsg.Text = (type ? "<i class='fa fa-check-circle fa-lg'></i> " : "<i class='fa fa-info-circle fa-lg'></i> ") + Message;
                lblMsg.CssClass = type ? "alert alert-success" : "alert alert-danger";
            }
            catch (Exception ex) { ShowMessage(ex.Message, false); }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void SaveDocument()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] 
             {    
                new DataColumn("ApplicantNo",typeof(int)),
                new DataColumn("AllDocument",typeof(string)),
                new DataColumn("DFileName",typeof(string)),
                new DataColumn("DocumentId",typeof(int)),

             });
                string str = "";
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {

                    Label DocId = (Label)GridView1.Rows[i].FindControl("lbldocId");
                    Label comp = (Label)GridView1.Rows[i].FindControl("lblcomp");
                    FileUpload FileUpload1 = (FileUpload)GridView1.Rows[i].FindControl("FileUpload1");
                    BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream);
                    byte[] bytes = br.ReadBytes(FileUpload1.PostedFile.ContentLength);
                    str = Convert.ToBase64String(bytes);
                    string filename = FileUpload1.PostedFile.FileName;
                    if (filename != "")
                    {
                        dt.Rows.Add(0, str, FileUpload1.PostedFile.FileName, Convert.ToInt32(DocId.Text));
                    }
                }
                ViewState["Document"] = dt;
            }
            catch (Exception ex)
            {

            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewRow")
            {
                int row = Convert.ToInt32(e.CommandArgument);
                Label DocId = (Label)GridView1.Rows[row].FindControl("lbldocId");

                //FileUpload FileUpload1 = (FileUpload)GridView1.Rows[row].FindControl("FileUpload1");
                //Stream fs = FileUpload1.PostedFile.InputStream;
                //BinaryReader br = new BinaryReader(fs);
                //Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                //string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                //Image1.ImageUrl = "data:image/png;base64," + base64String;
                Image1.Visible = true;
            }
        }
    }
}