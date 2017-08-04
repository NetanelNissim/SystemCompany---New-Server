﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Entities;
using DataAccessLayer;
using System.Data;

namespace Services
{
    public class ProjectCompaniesServices
    {
        private static ProjectCompaniesServices instance;
        public static ProjectCompaniesServices Instance
        {
            get { return instance ?? (instance = new ProjectCompaniesServices()); }
        }

        public void InsertProjectToCompany(int idCompany, int idProject, string priceType, string discriptions,
            DateTime? DateStartProject, DateTime? DateFinishProject, string paid, string destination)
        {
            ProjectToCompanyPersister.Instance.InsertProjectToCompany(idCompany, idProject, priceType, discriptions,
                DateStartProject, DateFinishProject, paid, destination);
        }

        public void UpdateProjectToCompany(int idCompany, int idProject,
            string priceType, string discriptions, DateTime? DateStartProject, DateTime? DateFinishProject,
            string paid, string destination)
        {
            ProjectToCompanyPersister.Instance.UpdateProjectToCompany(idCompany, idProject,
             priceType, discriptions, DateStartProject, DateFinishProject,
             paid, destination);
        }

        public DataTable GetAllProjectToCompany()
        {
            return DataTableCreator.Instance.ConvertListToDataTable(ProjectToCompanyPersister.Instance.GetAllProjectToCompany().ToList<Entities.ProjectCompanies>());
        }

        public List<string> GetDestination()
        {
           var projectComp = ProjectToCompanyPersister.Instance.GetDestination();
           var list = new List<string>();
           foreach (var item in projectComp)
           {
               list.Add(item.destination);
           }
           return list;
        }

        //public IEnumerable<Entities.ProjectCompanies> GetIds()
        //{
        //    return ProjectToCompanyPersister.Instance.GetIds();
        //}

        public string GetOldDestination(int idProject, int idCompany)
        {
            string oldDetination = null;
            var project =  ProjectToCompanyPersister.Instance.GetOldDestination(idProject, idCompany);
            foreach (var item in project)
            {
                if (idProject == item.idProject && idCompany == item.idCompany)
                {
                    oldDetination = item.destination;
                    break;
                }
            }
            return oldDetination;
        }

        public void DeleteProjectToCompany(int idProject, int idCompany)
        {
            ProjectToCompanyPersister.Instance.DeleteProjectToCompany(idCompany, idProject);
        }

        public bool ChackProjectToCompany(int idCompany , int idProject)
        {
           var projectCompany =  ProjectToCompanyPersister.Instance.GetIds();
           foreach (var item in projectCompany)
           {
               if(item.idCompany == idCompany && item.idProject == idProject)
                   return false;
           }
            return true;
        }

        //public List<dynamic> GetAllProjectToCompany()
        //{
        //    var projectCompany = ProjectToCompanyPersister.Instance.GetAllProjectToCompany();
        //    var list = new List<dynamic>();
        //    foreach (var item in projectCompany)
        //    {
        //        list.Add(new { });

        //    }
        //    return list;
        //}

        //public List<dynamic> GetDestination()
        //{
        //    var projectComp = ProjectToCompanyPersister.Instance.GetDestination();
        //    var list = new List<dynamic>();
        //    foreach (var item in projectComp)
        //    {
        //        list.Add(new { destination = item.destination });
        //    }
        //    return list;
        //}
    }
}
