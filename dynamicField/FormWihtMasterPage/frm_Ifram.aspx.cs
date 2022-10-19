using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace dynamicField.FormWihtMasterPage
{
    public partial class frm_Ifram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses2DataContext dtcc = new DataClasses2DataContext();
            //MstCity mst = new MstCity { CityCode = 0, CityCodeOther = 0, CityDesc = "", CityRemark = "" };
            //MstCity li = new MstCity();
            //dtcc.MstCities.InsertOnSubmit(mst);
            //dtcc.SubmitChanges();

            var a = (from MsCity in dtcc.MstCities
                           where MsCity.CityCode == 1
                           select MsCity).FirstOrDefault();            

            dynamic dm = dtcc.MstCities.Select(m => m.CityCode);

            PL.Ankit_PracticeEntities11 ap1 = new PL.Ankit_PracticeEntities11();
            //var vr = ap1.pl_model.ToList();
            //PL.PL_model plmdl = new PL.PL_model();
        }

        protected void btnGetPDF_Click(object sender, EventArgs e)
        {
            if (fuplPDF.HasFile)
            {
                string name = fuplPDF.PostedFile.FileName;
                FileInfo fi = new FileInfo(name);
                string extn = fi.Extension;                

                if (extn != ".pdf")
                {
                    System.IO.Stream fs = fuplPDF.PostedFile.InputStream;
                    System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                    byte[] pdffile = br.ReadBytes((Int32)fs.Length);
                    string fileBase64 = Convert.ToBase64String(pdffile);
                    ifrm1.Src = "data:image/png;base64," + fileBase64;
                }
                else
                {
                    string folderPath = Server.MapPath(@"~/PDF/");
                    fuplPDF.SaveAs(folderPath + name);
                    ifrm1.Src = "~/PDF/" + name;
                    FileInfo fileifo = new FileInfo(folderPath + name);
                    if (fileifo.Exists)
                    {
                        //fileifo.Delete();
                    }
                }
            }
        }

        protected void btnpopup_Click(object sender, EventArgs e)
        {
            
        }
    }
}