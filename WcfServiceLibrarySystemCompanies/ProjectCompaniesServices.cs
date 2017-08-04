using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfServiceLibrarySystemCompanies.DataContracts;

namespace WcfServiceLibrarySystemCompanies
{
    public class ProjectCompaniesServices //: IProjectCompaniesServices
    {
        public void Insert(ProjectCompanies projectCompany)
        {
            Services.ProjectCompaniesServices.Instance.InsertProjectToCompany(projectCompany.IdCompany, projectCompany.IdProject, projectCompany.PriceType, projectCompany.Discriptions, projectCompany.DateStartProject, projectCompany.DateFinishProject, projectCompany.Paid, projectCompany.Destination);
        }

        public void Update(ProjectCompanies projectCompany)
        {
            Services.ProjectCompaniesServices.Instance.UpdateProjectToCompany(projectCompany.IdCompany, projectCompany.IdProject, projectCompany.PriceType, projectCompany.Discriptions, projectCompany.DateStartProject, projectCompany.DateFinishProject, projectCompany.Paid, projectCompany.Destination);
        }

        public string GetAllProjectToCompany()
        {
            return Utils.ConvertDataTableToXML(Services.ProjectCompaniesServices.Instance.GetAllProjectToCompany(), "ProjectCompanies");
        }

        public List<string> GetDestination()
        {
            return Services.ProjectCompaniesServices.Instance.GetDestination();
        }

        public string GetOldDestination(ProjectCompanies projectCompany)
        {
            return Services.ProjectCompaniesServices.Instance.GetOldDestination(projectCompany.IdProject, projectCompany.IdCompany);
        }

        public void Delete(ProjectCompanies projectCompany)
        {
            Services.ProjectCompaniesServices.Instance.DeleteProjectToCompany(projectCompany.IdProject, projectCompany.IdCompany);
        }

        public bool CheckProjectToCompany(ProjectCompanies projectCompany)
        {
            return Services.ProjectCompaniesServices.Instance.ChackProjectToCompany(projectCompany.IdCompany, projectCompany.IdProject);
        }
    }
}
