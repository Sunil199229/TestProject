using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dynamicField.EncriptDecript
{
    public partial class FormEncriptDecript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            byte[] a = System.Text.Encoding.UTF8.GetBytes("1234");
            string b = Convert.ToBase64String(a);
            byte[] aa = System.Text.Encoding.UTF7.GetBytes("1234");
            string bb = Convert.ToBase64String(aa);
            byte[] aaa = System.Text.Encoding.UTF32.GetBytes("1234");
            string bbb = Convert.ToBase64String(aaa);
            lblDecriptedData.Text = b + "," + bb + "," + bbb;
        }

        protected void btnDecript_Click(object sender, EventArgs e)
        {
            //string a = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(txtEnciptedData.Text));
            string a = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String("MTIzNA=="));
            string aa = System.Text.Encoding.UTF7.GetString(Convert.FromBase64String("MTIzNA=="));
            string aaa = System.Text.Encoding.UTF32.GetString(Convert.FromBase64String("MQAAADIAAAAzAAAANAAAAA=="));
            lblDecriptedData.Text = a + "," + aa + "," + aaa;
        }
    }
}