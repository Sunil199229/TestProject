using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Text;

namespace dynamicField.FormWihtMasterPage
{
    public partial class SendSMSEMAIL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEMail_Click(object sender, EventArgs e)
        {
            //string toMail1 = "ankitcomputerrewa@gmail.com";
            //string toMail1 = "sunil.chauhan2938@gmail.com";
            string fromMail = "sunil.chauhan2938@gmail.com";
            string toMail = "sunil.chauhan2938@gmail.com";
            string mailBoady = "proj for vink Test";
            string Subject = "proj for vink Test";

            //MailMessage mmsg = new MailMessage(fromMail, toMail);
            MailMessage mmsg = new MailMessage();
            //mmsg.To.Add(toMail1);
            mmsg.To.Add(toMail);
            //mmsg.Bcc.Add(toMail1);
            //mmsg.Bcc.Add(toMail);
            //mmsg.From = new MailAddress(fromMail);
            //mmsg.From = new MailAddress(fromMail, "OCC");
            mmsg.From = new MailAddress(fromMail, "SSC", Encoding.UTF32);
            mmsg.Subject = Subject;
            mmsg.Body = mailBoady;
            if (flup.HasFile)
            {
                string filename = System.IO.Path.GetFileName(flup.PostedFile.FileName);
                mmsg.Attachments.Add(new Attachment(flup.PostedFile.InputStream, filename));
            }
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                System.Net.NetworkCredential basicCredential1 = new System.Net.NetworkCredential("ankitcomputerrewa@gmail.com", "Ankit@4903");
                client.Timeout = 10000;
                client.Credentials = basicCredential1;
                client.Send(mmsg);
            }
            catch (Exception ex)
            {
               
            }
           
        }

        protected void btnSMS_Click(object sender, EventArgs e)
        {

        }
    }
}