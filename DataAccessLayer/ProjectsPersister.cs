﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using EntityFrameworkDAL;
using Server;
using SystemCustomers.DBUtils;
using Extensions;

namespace DataAccessLayer
{
    public class ProjectsPersister 
    {
        #region Singleton
        private ProjectsPersister()
        {
        }
        private static ProjectsPersister instance;
        public static ProjectsPersister Instance
        {
            get { return instance ?? (instance = new ProjectsPersister()); }
        }
        #endregion Singleton

        private static project ConvertServices(Projects project)
        {
            return new project
                       {
                           projectName = project.projectName,
                           projectDescription = project.projectDescription,
                           idProject = project.idProject                         
                       };
        }

        public void InsertProject(string projectName, string projectDescription)
        {
            var project = new Projects(projectName, projectDescription);
            ProjectDataServices.Instance.InsertProject(project.MapTo(new project()));
        }

        public IEnumerable<Projects> GetAllProjects()
        {
            var project = ProjectDataServices.Instance.ViewingProject();
            return project.Select(projects => projects.MapTo( new Projects())).ToList();
        }

        public void UpdateProject(string projectName, string projectDescription, int idProject)
        {
            var project = new Projects(projectName, projectDescription, idProject);
            ProjectDataServices.Instance.UpdateProject(project.MapTo(new project()));
        }

        public void DeleteService(int idProject)
        {
            var project = new Projects(idProject);
            ProjectDataServices.Instance.DeleteProject(project.MapTo(new project()));
        }
    }
}
