using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dynamicField.FormWihtMasterPage
{
    public partial class login : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imglogin_Click(object sender, ImageClickEventArgs e)
        {
            int x_axis = (Int32)e.X;
            int y_axis = (Int32)e.Y;
            int x_axis1 = (Int32)e.XRaw;
            int y_axis2 = (Int32)e.YRaw;

            if (hdfCount.Value == "")
            {
                hdfCount.Value = "1";
            }
            else
            {
               hdfCount.Value = (Convert.ToInt16(hdfCount.Value) + 1).ToString();
            }

            if ((x_axis >= 30 && x_axis <= 63) && (y_axis >= 69 && y_axis <= 118))
            {
                hdfFirstStatus.Value = "true";
            }

            if ((x_axis >= 76 && x_axis <= 96) && (y_axis >= 23 && y_axis <= 66))
            {
                if (hdfFirstStatus.Value == "true")
                {
                    hdfSecondStatus.Value = "true";
                }               
            }

            if ((x_axis >= 61 && x_axis <= 83) && (y_axis >= 132 && y_axis <= 168))
            {
                if (hdfSecondStatus.Value == "true")
                {
                    hdfThirdStatus.Value = "true";
                }
            }

            if ((x_axis >= 79 && x_axis <= 97) && (y_axis >= 83 && y_axis <= 126))
            {
                if (hdfThirdStatus.Value == "true")
                {
                    hdfForthStatus.Value = "true";
                }               
            }

            if (Convert.ToInt16(hdfCount.Value) == 4)
            {
                if (hdfForthStatus.Value == "true") //hdfFirstStatus.Value == "true" && hdfSecondStatus.Value == "true" && hdfThirdStatus.Value == "true" && 
                {
                    hdfCount.Value = "";
                    Response.Redirect("~/FormWihtMasterPage/ExcelUpload");
                }
                else
                {
                    hdfCount.Value = "";
                    hdfFirstStatus.Value = "false";
                    hdfSecondStatus.Value = "false";
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "text", "alert('invalid password')", true);
                }
            }

        }
    }
}