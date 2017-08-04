using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityFrameworkDAL;

namespace Server
{
    public class ProjectToCompanyDataServices
    {

          #region Singelton

        private static ProjectToCompanyDataServices _instance;

        public static ProjectToCompanyDataServices Instance
        {
            get { return _instance ?? (_instance = new ProjectToCompanyDataServices()); }
        }

        private ProjectToCompanyDataServices()
        {
            // this will happens only once
            // Do your connection stuff in here
        }

        #endregion Singelton



        #region Project to Company

        public IEnumerable<View_Project_Company> ViewProjectCompany()
        {
            using (var ctx = new SystemCompanyEntities())
            {
                return ctx.View_Project_Company.ToList();
            }
        }

        public IEnumerable<ProjectCompany> ViewingAllProjectToCompany()
        {
            using (var ctx = new SystemCompanyEntities())
            {
                try
                {
                    return
                          ctx.ProjectCompanies.Include("Company").Include("Company.DateProjectCompany").Include("project").ToList
                              ();
                }
                catch (Exception ex )
                {
                    ex.Message.ToString();
                    return null;
                
                }
            }
        }

        public IEnumerable<ProjectCompany> ViewingProjectToCompany()
        {
            using (var ctx = new SystemCompanyEntities())
            {
                return ctx.ProjectCompanies.ToList();
            }
        }

        public void InsertProjectToCompany(ProjectCompany projectCompany, DateProjectCompany dateProjectCompany)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                ctx.AddToProjectCompanies(projectCompany);
                ctx.SaveChanges();
                ctx.AddToDateProjectCompany(dateProjectCompany);
                ctx.SaveChanges();
            }
        }

        public void UpdateProjectToCompany(ProjectCompany projectCompany, DateProjectCompany dateProjectCompany)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var PC =
                    ctx.ProjectCompanies.First(
                        pC => pC.idProject == projectCompany.idProject && pC.idCompany == projectCompany.idCompany);
                PC.idProject = projectCompany.idProject;
                PC.idCompany = projectCompany.idCompany;
                PC.priceType = projectCompany.priceType;
                PC.paid = projectCompany.paid;
                PC.destination = projectCompany.destination;
                PC.discriptions = projectCompany.discriptions;
                ctx.SaveChanges();
                var DPC =
                    ctx.DateProjectCompany.First(
                        dpC =>
                        dpC.idProject == dateProjectCompany.idProject && dpC.idCompany == dateProjectCompany.idCompany);
                DPC.idCompany = dateProjectCompany.idCompany;
                DPC.idProject = dateProjectCompany.idProject;
                DPC.DateStartProject = dateProjectCompany.DateStartProject;
                DPC.DateFinishProject = dateProjectCompany.DateFinishProject;
                ctx.SaveChanges();
            }
        }

        public void DeleteProjectToCompany(ProjectCompany projectCompany)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var PC =
                    ctx.ProjectCompanies.First(
                        pC => pC.idProject == projectCompany.idProject && pC.idCompany == projectCompany.idCompany);
                ctx.ProjectCompanies.DeleteObject(PC);
                ctx.SaveChanges();
                var DPC =
                    ctx.DateProjectCompany.First(
                        pC => pC.idProject == projectCompany.idProject && pC.idCompany == projectCompany.idCompany);
                ctx.DateProjectCompany.DeleteObject(DPC);
                ctx.SaveChanges();
            }
        }

     /*   public List<ProjectCompany> GetOldDestination(ProjectCompany projectCompany)
        {
            var query3 = _mDb.ProjectCompanies.Where(item => item.idCompany == projectCompany.idCompany && item.idProject == projectCompany.idProject).Select(item => new { Destination = item.destination }).ToList();
            var list = new List<ProjectCompany>();
            foreach (var result in query3)
            {
                list.Add(new ProjectCompany
                {
                    destination = result.Destination
                });
            }
            return list;
        }*/

        #endregion Project to Company


        public IEnumerable<ProjectCompany> ViewingDestination()
        {
            using (var ctx = new SystemCompanyEntities())
            {
              var query = ctx.ProjectCompanies.Select(item => new { Destination = item.destination }).ToList();
                 var list = new List<ProjectCompany>();
                 foreach (var result in query)
                 {
                     list.Add(new ProjectCompany
                     {
                         destination = result.Destination
                     });
                 }
                 return list;
            }
        }

        public IEnumerable<ProjectCompany> ViewingOldDestination(ProjectCompany projectCompany)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var query = ctx.ProjectCompanies.Where(item => item.idCompany == projectCompany.idCompany && item.idProject == projectCompany.idProject).Select(item => new { Destination = item.destination }).ToList();
                var list = new List<ProjectCompany>();
                foreach (var result in query)
                {
                    list.Add(new ProjectCompany
                    {
                        destination = result.Destination
                    });
                }
                return list;
            }
            
        }

        public IEnumerable<ProjectCompany> ViewingIds()
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var query = ctx.ProjectCompanies.Select(item => new { idCompany = item.idCompany, idProject = item.idProject }).ToList();
                var list = new List<ProjectCompany>();
                foreach (var result in query)
                {
                    list.Add(new ProjectCompany
                    {
                        idCompany = result.idCompany,
                        idProject = result.idProject
                    });
                }
                return list;
            }
        }
    }
}
