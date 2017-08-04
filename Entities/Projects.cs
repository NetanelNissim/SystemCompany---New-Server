using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Projects
    {
        public Projects(string projectName,string projectDescription, int idProject)
        {
            this.projectName = projectName;
            this.projectDescription = projectDescription;
            this.idProject = idProject;
        }

        public Projects(string projectName, string projectDescription)
        {
            this.projectName = projectName;
            this.projectDescription = projectDescription;
        }

        public Projects()
        { 
        
        }

        public Projects(int IdProject)
        {
            this.idProject = IdProject;
        }

        public string projectName { get; set; }
        public int idProject { get; set; }
        public string projectDescription { get; set; }
    }
}
