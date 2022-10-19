using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dynamicField.FormWihtMasterPage
{
    public partial class ReadFileProperty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngetdetail_Click(object sender, EventArgs e)
        {
            saveDataInExcel();
        }

        public void saveDataInExcel()
        {
            System.IO.DirectoryInfo dirInfo = new DirectoryInfo(@"" + txtPickPath.Text + "\\");

            System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*");
            XLWorkbook workBook = new XLWorkbook();
            var worksheet = workBook.Worksheets.Add("Sheet1");
            worksheet.Cell(1, 1).Value = "Name";
            worksheet.Cell(1, 2).Value = "LastAccessTime";
            worksheet.Cell(1, 3).Value = "Length";
            worksheet.Cell(1, 4).Value = "Version";
            int i = 2;
            foreach (System.IO.FileInfo fi in fileNames)
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(fi.DirectoryName + "\\" + fi.Name);
                string version = versionInfo.FileVersion;
                worksheet.Cell(i, 1).Value = fi.Name;
                worksheet.Cell(i, 2).Value = fi.LastAccessTime;
                worksheet.Cell(i, 3).Value = fi.Length;
                worksheet.Cell(i, 4).Value = version;
                i++;
            }
            workBook.SaveAs(@"" + txtSavePath.Text + "\\"+ txtFileName.Text + ".xlsx");
        }
    }
}