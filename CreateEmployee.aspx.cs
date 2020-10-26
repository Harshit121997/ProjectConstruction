using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectConstruction
{
    public partial class CreateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click1(object sender, EventArgs e)
        {
            EmployeeEntity employeeEntity = GetEmployeeEntity();
            Project project = new Project();
            project.AddEmployee(employeeEntity);
            lblMessage.Text = "Employee Created Succesfully";
            clearcontrol();
        }

        public EmployeeEntity GetEmployeeEntity()
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();
            employeeEntity.EmployeeName = txtEmpName.Text;
            employeeEntity.Department = DdlDepartment.Text;
            return employeeEntity;
        }

        public void clearcontrol()
        {
            txtId.Text = string.Empty;
            txtEmpName.Text = string.Empty;
            DdlDepartment.Text = string.Empty;
        }
    }
}
