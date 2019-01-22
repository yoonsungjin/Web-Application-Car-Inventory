using DBLib.DAL;
using DBLib.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalWebApp_SungjinYoon
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;
            MemberDAL memberDAL = new MemberDAL();
            Member m = new Member(name, phone, email, address, password);

            memberDAL.Add(m);
            lblStatus.Text = "Registration was successful";
        }
    }

}