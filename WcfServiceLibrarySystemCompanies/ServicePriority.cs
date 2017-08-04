using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WcfServiceLibrarySystemCompanies
{
    public class ServicePriority 
    {
        public void InsertPriority(Priority priority)
        {
            Services.PriorityServices.Instance.InsertPriority(priority.TypePriority);
        }

        public string GetAllPriorities()
        {
            return Utils.ConvertDataTableToXML(Services.PriorityServices.Instance.GetAllPriorities(),"Priority");
        }
        public DataSet GetAllPrioritiesDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(Services.PriorityServices.Instance.GetAllPriorities());
            return ds;
        }

        public List<Tuple<int, string>> GetAllPrioritiesToDropDown()
        {
            return Services.PriorityServices.Instance.GetAllPrioritiesToDropDown();
        }

        public void DeletePriority(Priority priority)
        {
            Services.PriorityServices.Instance.DeletePriority(priority.IdPriority);
        }


        internal bool CheckPriorityId(Priority priority)
        {
            return Services.PriorityServices.Instance.CheckPriorityId(priority.IdPriority);
        }
    }
}
