using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectConstruction
{
    public partial class CreateProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveProject_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            project.AddProject(txtProject.Text);
            {
                lblMessage.Text = "Project Created Succesfully";
            }
        }
    }
}
