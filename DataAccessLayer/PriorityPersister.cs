using System;
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
    public class PriorityPersister 
    {
        #region Singleton
        private PriorityPersister()
        {
        }
        private static PriorityPersister instance;
        public static PriorityPersister Instance
        {
            get { return instance ?? (instance = new PriorityPersister()); }
        }
        #endregion Singleton

        private static Priority ConvertPriority(Priorities priority)
        {
            return new Priority
                       {
                           TypePriority = priority.TypePriority,
                           idPriority = priority.idPriority                         
                       };
        }

        public void InsertPriority(string typePriority)
        {
            var priority = new Priorities(typePriority);
            //  PriorityDataServices.Instance.InsertPriority(ConvertPriority(priority));
            PriorityDataServices.Instance.InsertPriority(priority.MapTo(new Priority()));

        }

        public IEnumerable<Priorities> GetAllPriorities()
        {
            var priority = PriorityDataServices.Instance.ViewingPriority();

          //  return priority.Select(priorities => new Priorities(priorities.TypePriority, priorities.idPriority)).ToList();
            return priority.Select(priorities => priorities.MapTo( new Priorities())).ToList();
        }

        //public void UpdateService(string  serviceName, int idService)
        //{
        //    var service = new Priorities(serviceName, idService);
        //    PriorityDataServices.Instance.Update(ConvertPriority(service));
        //}

        public void DeletePriority(int idPriority)
        {
            var priority = new Priorities(idPriority);
           // PriorityDataServices.Instance.DeletePriority(ConvertPriority(priority));
            PriorityDataServices.Instance.DeletePriority(priority.MapTo(new Priority()));
        }
    }
}
