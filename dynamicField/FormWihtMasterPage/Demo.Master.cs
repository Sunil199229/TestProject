using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Newtonsoft.Json;

namespace dynamicField.FormWihtMasterPage
{
    public partial class Demo : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = Request.QueryString["ID"];
            if (Request.UrlReferrer != null)
            {
                string fileName = System.IO.Path.GetFileName(Request.UrlReferrer.AbsolutePath);
                if (fileName == "SecondPage.aspx")
                {
                    divCom.Visible = true;
                }
            }


            if (System.IO.Path.GetFileName(Request.Url.AbsolutePath) == "SecondPage")
            {
                 divCom.Visible = true;
            }


            string var = "{\"Status\":\"0\",\"EwaybillStatus\":\"0\",\"ErrorResponse\":[{\"ErrorInfo\":\"5002:Applicationerror,issuewithapplicationwhileprocessingtherequest.Pleasetryagain.IferrorpersistskindlyraiseaticketalongwithrequestJSON,errordetailsandtimestampoftheerroroccurrence.\",\"CoulumnName\":null,\"ColumnValue\":null}],\"EInvoiceStatus\":null,\"AuthToken\":\"woJqPiauNggUwdcxaeM7BkMoI\",\"AckNo\":null,\"AckDate\":null,\"IRN\":null,\"SignedInvoice\":null,\"SignedQRCode\":null,\"QrCodeImage\":null,\"EwbNo\":null,\"EwbDt\":null,\"EwbValidTill\":null,\"Distance\":\"0\"}";
            dynamic aaaa = JsonConvert.DeserializeObject<object>(var);
            string status = aaaa.Status;
            string msg = aaaa.ErrorResponse[0].ErrorInfo;

        }
    }
}