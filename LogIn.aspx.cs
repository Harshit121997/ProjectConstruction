using System;
using System.Data;

namespace ProjectConstruction
{
    public partial class LogIn1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DBLogin dBLogin = new DBLogin();
            DataTable dataTable = dBLogin.ValidateLogin(txtEmail.Text, txtPassword.Text);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                Response.Redirect("DashBoard.aspx");
            }
            else
            {
                lblMessage.Text = "Please check email & password";
            }
        }
    }
}

