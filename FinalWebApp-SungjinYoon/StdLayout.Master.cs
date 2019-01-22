using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApp_SungjinYoon
{
    public partial class StdLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Label1.Text = "Wecome " + Context.User.Identity.Name;
                lbtnLogin.Visible = false;//!IsAuthenticated
                lbtnLogout.Visible = true; //IsAuthenticated
                lbtnReg.Visible = false;
            }
            else
            {
                Label1.Text = "Wecome Guest";
                lbtnLogin.Visible = true;
                lbtnLogout.Visible = false;
                lbtnReg.Visible = true;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/welcome.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registration.aspx");
        }
    }
}