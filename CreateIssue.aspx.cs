using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectConstruction
{
    public partial class CreateIssue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindProject();
            BindEmployee();
        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateIssueEntity createIssueEntity = GetCreateIssueEntity();
            Project project = new Project();
            project.CreateIssue(createIssueEntity);
            {
                lblMessage.Text = "Issue Created Succesfully";
                ClearControl();
            }
        }

        private void BindProject()
        {
            DataTable dtProject = new DataTable();
            Project project = new Project();
            dtProject = project.GetProject();
            DdlProject.DataSource = dtProject;
            DdlProject.DataTextField = "ProjectName";
            DdlProject.DataValueField = "ProjectId";
            DdlProject.DataBind();
            DdlProject.Items.Insert(0, new ListItem("-----Select-----", string.Empty));
        }

        private void BindEmployee()
        {
            DataTable dtEmployee = new DataTable();
            Project project = new Project();
            dtEmployee = project.GetEmployee();
            DdlAssign.DataSource = dtEmployee;
            DdlAssign.DataValueField = "EmployeeName";
            DdlAssign.DataBind();
            DdlAssign.Items.Insert(0, new ListItem("-----Select-----", string.Empty));
        }
            public CreateIssueEntity GetCreateIssueEntity()
        {
            CreateIssueEntity createIssueEntity = new CreateIssueEntity();
            createIssueEntity.ProjectName = DdlProject.Text;
            createIssueEntity.IssueType = DdlIssue.Text;
            createIssueEntity.EpicName = txtEpicName.Text;
            createIssueEntity.Summary = txtSummary.Text;
            createIssueEntity.Description = txtDescription.Value;
            createIssueEntity.Priority = DdlPriority.Text;
            createIssueEntity.Assign = DdlPriority.Text;
            return createIssueEntity;
        }

        private void ClearControl()
        {
            DdlProject.Text = string.Empty;
            DdlIssue.Text = string.Empty;
            txtEpicName.Text = string.Empty;
            txtSummary.Text = string.Empty;
            txtDescription.Value = string.Empty;
            DdlPriority.Text = string.Empty;
            DdlAssign.Text = string.Empty;
        }
    }
}