using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;
using System.Data;

namespace Services
{
    public class ProjectsServices
    {
        private static ProjectsServices instance;
        public static ProjectsServices Instance
        {
            get { return instance ?? (instance = new ProjectsServices()); }
        }

        public void InsertProject(string projectName, string projectDescription)
        {
            ProjectsPersister.Instance.InsertProject(projectName, projectDescription);
        }

        public void UpdateProject(string projectName, string projectDescription, int idProject )
        {
            ProjectsPersister.Instance.UpdateProject(projectName, projectDescription, idProject);
        }

        public DataTable GetAllProjects()
        {
            return DataTableCreator.Instance.ConvertListToDataTable(ProjectsPersister.Instance.GetAllProjects().ToList<Entities.Projects>());
        }

        public void DeleteService(int idProject)
        {
            ProjectsPersister.Instance.DeleteService(idProject);
        }

        public List<Tuple<string, int>> GetAllProjectsToDropDown()
        {
            var project =  ProjectsPersister.Instance.GetAllProjects();
          //  var list = new List<dynamic>();
            var list = new List<Tuple <string, int>>();
            foreach (var item in project)
            {
                list.Add(new Tuple <string, int>(item.projectName , item.idProject ));
            }
            return list;
        }
    }
}
