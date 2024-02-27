using System;
using System.Web.Security;

namespace RainbowSchoolsUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            LblMsg.Visible=true;
            if((TxtName.Text == "Admin") && (TxtPwd.Text == "Pass@123"))
            {
                FormsAuthentication.RedirectFromLoginPage(TxtName.Text, true);
            }
            else
            {
                LblMsg.Text = "Invalid Credentials";
            }
        }
    }
}