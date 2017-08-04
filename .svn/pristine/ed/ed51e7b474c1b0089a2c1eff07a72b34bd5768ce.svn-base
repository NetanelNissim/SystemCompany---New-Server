using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services;
using WcfServiceLibrarySystemCompanies.DataContracts;
using System.Data;

namespace WcfServiceLibrarySystemCompanies
{
    public class ServiceProject
    {
        public void Insert(Project project)
        {
            ProjectsServices.Instance.InsertProject(project.projectName,project.projectDescription);
        }

        public void Update(Project project)
        {
            ProjectsServices.Instance.UpdateProject(project.projectName,project.projectDescription,project.idProject);
        }

        public string GetAllProjects()
        {
            return Utils.ConvertDataTableToXML(ProjectsServices.Instance.GetAllProjects(), "Project");
        }

        public DataSet GetAllProjectDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(ProjectsServices.Instance.GetAllProjects());
            return ds;
        }

        public void Delete(Project project)
        {
            ProjectsServices.Instance.DeleteService(project.idProject);
        }

        public List<Tuple<string, int>> GetAllProjectsToDropDown()
        {
            return ProjectsServices.Instance.GetAllProjectsToDropDown();
        }
    }
}
