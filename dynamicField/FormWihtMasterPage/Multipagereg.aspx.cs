using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dynamicField.FormWihtMasterPage
{
    public partial class Multipagereg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnPrv_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
            }

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (divSecond.Visible == false)
            {
                divFirst.Visible = false;
                divSecond.Visible = true;
                btnPrv.Visible = true;

            }
            else if (divThird.Visible == false && divSecond.Visible == true)
            {
                divSecond.Visible = false;
                divThird.Visible = true;
                btnSubmit.Visible = true;
            }
            else
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}