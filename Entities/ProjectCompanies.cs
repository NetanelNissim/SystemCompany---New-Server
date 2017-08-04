using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ProjectCompanies
    {
        public ProjectCompanies(int idCompany, int idProject, string priceType, string discriptions, string paid, string destination)
        {
            this.idCompany = idCompany;
            this.idProject = idProject;
            this.priceType = priceType;
            this.discriptions = discriptions;
            this.paid = paid;
            this.destination = destination;
        }

        public ProjectCompanies(int idCompany, int idProject, string companyName, string projectName,
           string priceType, string discriptions,DateTime? dateStartProject,DateTime? dateFinishProject, string paid, string destination)
        {
            this.idCompany = idCompany;
            this.idProject = idProject;
            this.companyName = companyName;
            this.projectName = projectName;
            this.priceType = priceType;
            this.discriptions = discriptions;
            this.DateStartProject = dateStartProject;
            this.DateFinishProject = dateFinishProject;
            this.paid = paid;
            this.destination = destination;
        }



        public ProjectCompanies(int idCompany, int idProject)
        {
            this.idCompany = idCompany;
            this.idProject = idProject;
        }

        public ProjectCompanies()
        { }

        public int idProject { get; set; }
        public int idCompany { get; set; }
        public string companyName { get; set; }
        public string projectName { get; set; }
        public string priceType { get; set; }
        public string discriptions { get; set; }
        public DateTime? DateStartProject { get; set; }
        public DateTime? DateFinishProject { get; set; }
        public string paid { get; set; }
        public string destination { get; set; }
    }
}
