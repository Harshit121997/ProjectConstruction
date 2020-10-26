using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectConstruction
{
    public partial class Project
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        public void AddProject(String ProjectName)
        {
            SqlCommand command = new SqlCommand();
            DataTable dtUserMaster = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.CommandText = "Sp_TblProject";
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlProjectName = new SqlParameter("@ProjectName", SqlDbType.VarChar);
                sqlProjectName.Value = ProjectName;
                command.Parameters.Add(sqlProjectName);
                command.ExecuteNonQuery();

            }
        }

        public void CreateIssue(CreateIssueEntity createIssueEntity)
        {
            SqlCommand command = new SqlCommand();
            DataTable dtUserMaster = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.CommandText = "Sp_CreateIssue";
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlProjectName = new SqlParameter("@ProjectName", SqlDbType.VarChar);
                sqlProjectName.Value = createIssueEntity.ProjectName;
                command.Parameters.Add(sqlProjectName);
                SqlParameter sqlIssueType = new SqlParameter("@IssueType", SqlDbType.VarChar);
                sqlIssueType.Value = createIssueEntity.IssueType;
                command.Parameters.Add(sqlIssueType);
                SqlParameter sqlEpicName = new SqlParameter("@EpicName", SqlDbType.VarChar);
                sqlEpicName.Value = createIssueEntity.EpicName;
                command.Parameters.Add(sqlEpicName);
                SqlParameter sqlSummary = new SqlParameter("@Summary", SqlDbType.VarChar);
                sqlSummary.Value = createIssueEntity.Summary;
                command.Parameters.Add(sqlSummary);
                SqlParameter sqlDescription = new SqlParameter("@Description", SqlDbType.VarChar);
                sqlDescription.Value = createIssueEntity.Description;
                command.Parameters.Add(sqlDescription);
                SqlParameter sqlPriority = new SqlParameter("@Priority", SqlDbType.VarChar);
                sqlPriority.Value = createIssueEntity.Priority;
                command.Parameters.Add(sqlPriority);
                SqlParameter sqlAssign = new SqlParameter("@Assign", SqlDbType.VarChar);
                sqlAssign.Value = createIssueEntity.Assign;
                command.Parameters.Add(sqlAssign);
                command.ExecuteNonQuery();

            }
        }

        public void AddEmployee(EmployeeEntity employeeEntity)
        {
            SqlCommand command = new SqlCommand();
            DataTable dtUserMaster = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.CommandText = "Sp_AddEmployee";
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlEmployeeName = new SqlParameter("@EmployeeName", SqlDbType.VarChar, 100);
                sqlEmployeeName.Value = employeeEntity.EmployeeName;
                command.Parameters.Add(sqlEmployeeName);
                SqlParameter sqlDepartment = new SqlParameter("@Department", SqlDbType.VarChar, 100);
                sqlDepartment.Value = employeeEntity.Department;
                command.Parameters.Add(sqlDepartment);
                command.ExecuteNonQuery();

            }
        }

        public DataTable GetProject()
        {
            SqlCommand command = new SqlCommand();
            DataTable dtProject = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                command.CommandText = "Sp_GetProject";
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dtProject);
            }
            return dtProject;
        }

        public DataTable GetEmployee()
        {
            SqlCommand command = new SqlCommand();
            DataTable dtProject = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                command.CommandText = "Sp_GetEmployee";
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dtProject);
            }
            return dtProject;
        }
    }

}
