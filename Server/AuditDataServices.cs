using EntityFrameworkDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
   public class AuditDataServices
    {

        #region Singelton

        private static AuditDataServices _instance;

        public static AuditDataServices Instance
        {
            get { return _instance ?? (_instance = new AuditDataServices()); }
        }

        private AuditDataServices()
        {
            // this will happens only once
            // Do your connection stuff in here
        }

        #endregion Singelton

        private void InsertDataToAudit(SysAudit audit)
        {
            using (var ctx = new SystemCompanyEntities())
            {
                ctx.AddToSysAudit(audit);
                ctx.SaveChanges();
            }
        }
        public void InsertAudit(int key1, int key2, int key3, string tableName, string value
            , string fieldAction)
        {
            var audit = new SysAudit();
            audit.key1 = key1;
            audit.key2 = key2;
            audit.key3 = key3;
            audit.tableName = tableName;
            audit.value = value;
            audit.DateInserted = DateTime.Now;
            audit.FieldAction = fieldAction;
            this.InsertDataToAudit(audit);
        }
    }
}
