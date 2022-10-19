using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.OleDb;
using ClosedXML.Excel;

namespace dynamicField.FormWihtMasterPage
{
    public partial class ExcelUpload : System.Web.UI.Page
    {
        List<object> lst = new List<object>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Session["lstbox2"] = null;
                readExcel();
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUploadExcelFile.HasFile)
            {
                string fileName = Path.GetFileName(FileUploadExcelFile.PostedFile.FileName);
                string fileExt = Path.GetExtension(FileUploadExcelFile.PostedFile.FileName);
                string fileFolder = "~/Excel/";
                string filePath = Server.MapPath(fileFolder + fileName);
                FileUploadExcelFile.SaveAs(filePath);
                copyToDataTable(filePath, fileExt);
            }
        }

        public void copyToDataTable(string filePath, string fileExt)
        {
            using (XLWorkbook workBook = new XLWorkbook(filePath))
            {
                IXLWorksheet workSheet = workBook.Worksheet(1);
                DataTable dt = new DataTable();
                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {
                    if (firstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        dt.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }
                lstbox.DataSource = dt;
                lstbox.DataValueField = "Sr. No.";
                lstbox.DataTextField = "Demand NO.";
                lstbox.DataBind();
            }
        }

        public void readExcel()
        {
            string filePath = Server.MapPath("../Excel/einvoice.xlsx");
            using (XLWorkbook workBook = new XLWorkbook(filePath))
            {
                IXLWorksheet workSheet = workBook.Worksheet(1);
                DataTable dt = new DataTable();
                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {
                    if (firstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        dt.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }
                }
                lstbox.DataSource = dt;
                lstbox.DataValueField = "Sr. No.";
                lstbox.DataTextField = "Demand NO.";
                lstbox.DataBind();

                lstbox1.DataSource = dt;
                lstbox1.DataValueField = "Sr. No.";
                lstbox1.DataTextField = "IdaRef No.";
                lstbox1.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (Session["lstbox2"] != null)
            {
                lst =(List<object>)Session["lstbox2"];
            }
            string newListName = "";
            string NewListValue = "";

            for (int i = 0; i < lstbox.Items.Count; i++)
            {
                if (lstbox.Items[i].Selected)
                {
                    lst.Add(lstbox.Items[i]);
                    Session["lstbox2"] = lst; ;
                    newListName = lstbox.Items[i].Text;
                    NewListValue = lstbox.Items[i].Value;
                } 
            }
            
            lstbox2.DataSource = lst;
            lstbox2.DataTextField = "Text";
            lstbox2.DataValueField = "Value";
            lstbox2.DataBind();
        }

        protected void btnRmv_Click(object sender, EventArgs e)
        {
            if (Session["lstbox2"] != null)
            {
                lst = (List<object>)Session["lstbox2"];
            }

            for (int i = 0; i < lstbox2.Items.Count; i++)
            {
                if (lstbox2.Items[i].Selected)
                {
                    lst.Remove(lstbox2.Items[i]);
                    Session["lstbox2"] = lst; ;
                } 
            }
            lstbox2.DataSource = lst;
            lstbox2.DataTextField = "Text";
            lstbox2.DataValueField = "Value";
            lstbox2.DataBind();
        }
    }
}