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
    public class ProjectToCompanyPersister 
    {
        #region Singleton
        private ProjectToCompanyPersister()
        {
        }
        private static ProjectToCompanyPersister instance;
        public static ProjectToCompanyPersister Instance
        {
            get { return instance ?? (instance = new ProjectToCompanyPersister()); }
        }
        #endregion Singleton

        private static ProjectCompany ConvertProjectToCompany(ProjectCompanies projComp)
        {
            return new ProjectCompany
                       {
                           idCompany = projComp.idCompany,
                           idProject = projComp.idProject,
                           priceType = projComp.priceType,
                           discriptions = projComp.discriptions,
                           paid = projComp.paid,
                           destination = projComp.destination
                       };
        }

        private static ProjectCompany ConvertIdsProjectToCompany(ProjectCompanies projComp)
        {
            return new ProjectCompany
            {
                idCompany = projComp.idCompany,
                idProject = projComp.idProject
            };
        }

        private static DateProjectCompany ConvertDateProjectCompany(DateProjectCompanies dataProjectCompany)
        {
            return new DateProjectCompany
            {
                idCompany = dataProjectCompany.idCompany,
                idProject = dataProjectCompany.idProject,
                DateStartProject = dataProjectCompany.DateStartProject,
                DateFinishProject = dataProjectCompany.DateFinishProject
            };
        }

        public void InsertProjectToCompany(int idCompany, int idProject, string priceType, string discriptions, DateTime? DateStartProject, DateTime? DateFinishProject,
            string paid, string destination)
        {
            var projectToCompany = new ProjectCompanies(idCompany, idProject, priceType, discriptions, paid, destination);
            var dateProjectCompany = new DateProjectCompanies(idCompany, idProject,DateStartProject, DateFinishProject);
            //ProjectToCompanyDataServices.Instance.InsertProjectToCompany(ConvertProjectToCompany(projectToCompany), ConvertDateProjectCompany(dateProjectCompany));
            ProjectToCompanyDataServices.Instance.InsertProjectToCompany(projectToCompany.MapTo(new ProjectCompany()), dateProjectCompany.MapTo(new DateProjectCompany()));
        }

        public IEnumerable<ProjectCompanies> GetAllProjectToCompany()
        {
            var proCom = ProjectToCompanyDataServices.Instance.ViewingAllProjectToCompany();
            var list = new List<ProjectCompanies>();
            foreach (var pc in proCom)
            {
                var dpc = pc.Company.DateProjectCompany.First(item => item.idProject == pc.idProject && item.idCompany == pc.idCompany);
                if (dpc.DateStartProject != null)
                    if (dpc.DateFinishProject != null)
                        list.Add(new ProjectCompanies
                        {
                            companyName = dpc.Companys.companyName,
                            DateStartProject = dpc.DateStartProject.Value,
                            DateFinishProject = dpc.DateFinishProject.Value,
                            destination = pc.destination,
                            discriptions = pc.discriptions,
                            idCompany = pc.idCompany,
                            idProject = pc.idProject,
                            paid = pc.paid,
                            priceType = pc.priceType,
                            projectName = dpc.project.projectName
                        });
            }
            return list;
        }

        public void UpdateProjectToCompany(int idCompany, int idProject, string priceType, string discriptions,
            DateTime? DateStartProject, DateTime? DateFinishProject, string paid, string destination)
        {
            var projectToCompany = new ProjectCompanies(idCompany, idProject, priceType, discriptions, paid, destination);
            var dateProjectCompany = new DateProjectCompanies(idCompany, idProject, DateStartProject, DateFinishProject);
            //ProjectToCompanyDataServices.Instance.UpdateProjectToCompany(ConvertProjectToCompany(projectToCompany), ConvertDateProjectCompany(dateProjectCompany));
            ProjectToCompanyDataServices.Instance.UpdateProjectToCompany(projectToCompany.MapTo(new ProjectCompany()), dateProjectCompany.MapTo(new DateProjectCompany()));
        }

        public void DeleteProjectToCompany(int idCompany, int idProject)
        {
            var proCom = new ProjectCompanies(idCompany,idProject);
            ProjectToCompanyDataServices.Instance.DeleteProjectToCompany(proCom.MapTo(new ProjectCompany()));
        }

        public IEnumerable<ProjectCompanies> GetDestination()
        {
            var proCom = ProjectToCompanyDataServices.Instance.ViewingDestination();
            var list = new List<ProjectCompanies>();
            foreach (var pc in proCom)
            {
                        list.Add(new ProjectCompanies
                        {
                            destination = pc.destination
                        });
            }
            return list;
        }

        public IEnumerable<ProjectCompanies> GetOldDestination(int idProject, int idCompany)
        {
            var proCom = new ProjectCompanies(idCompany, idProject);
            var query = ProjectToCompanyDataServices.Instance.ViewingOldDestination(proCom.MapTo(new ProjectCompany()));
            var list = new List<ProjectCompanies>();
            foreach (var pc in query)
            {
                list.Add(new ProjectCompanies
                {
                    destination = pc.destination
                });
            }
            return list;
        }

        public IEnumerable<ProjectCompanies> GetIds()
        {
            var proCom = ProjectToCompanyDataServices.Instance.ViewingIds();
            var list = new List<ProjectCompanies>();
            foreach (var pc in proCom)
            {
                list.Add(new ProjectCompanies
                {
                    idCompany = pc.idCompany,
                    idProject = pc.idProject
                });
            }
            return list;
        }
    }
}
