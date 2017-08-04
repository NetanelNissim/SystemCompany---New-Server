using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityFrameworkDAL;

namespace Server
{
   public class PriorityDataServices
    {
         #region Singelton

        private static PriorityDataServices _instance;

        public static PriorityDataServices Instance
        {
            get { return _instance ?? (_instance = new PriorityDataServices()); }
        }

        private PriorityDataServices()
        {
            // this will happens only once
            // Do your connection stuff in here
        }

        #endregion Singelton

        #region Priority

        public IEnumerable<Priority> ViewingPriority()
        {
            using (var ctx = new SystemCompanyEntities())
            {
                return ctx.Priorities.ToList();
            }
        }

        public void InsertPriority(Priority priority)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                ctx.AddToPriorities(priority);
                ctx.SaveChanges();
            }
        }

        public void DeletePriority(Priority priority)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                var priorityToDelete = ctx.Priorities.First(e => e.idPriority == priority.idPriority);
                AuditDataServices.Instance.InsertAudit(priorityToDelete.idPriority, 0, 0, "Priorities", priorityToDelete.TypePriority, "Delete");
                ctx.DeleteObject(priorityToDelete);
                ctx.SaveChanges();
            }
        }

        #endregion Priority
    }
}
