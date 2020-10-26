using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectConstruction
{
    public class CreateIssueEntity
    {
            public string ProjectName { get; set; }
            public string IssueType { get; set; }
            public string EpicName { get; set; }
            public string Summary { get; set; }
            public string Description { get; set; }
            public string Priority { get; set; }
            public string Assign { get; set; }
    }

    public class EmployeeEntity
    {
        public string EmployeeName { get; set; }
        public string Department { get; set; }
    }
    }