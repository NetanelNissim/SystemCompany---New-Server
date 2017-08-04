using Entities;
using EntityFrameworkDAL;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class AuditPersister
    {

        #region Singleton
        private AuditPersister()
        {
        }
        private static AuditPersister instance;
        public static AuditPersister Instance
        {
            get { return instance ?? (instance = new AuditPersister()); }
        }
        #endregion Singleton

        private static SysAudit ConvertAudit(Audit service)
        {
            return new SysAudit
            {
                key1 = service.Key1,
                key2 = service.Key2,
                key3 = service.Key3,
                tableName = service.TableName,
                value = service.Value,
                FieldAction = service.FieldAction,
                DateInserted = service.DateInserted
            };
        }

        public void InsertAudit(int key1, int key2, int key3, string tableName, string value,
            string fieldAction, DateTime? dateInserted)
        {
            var audit = new Audit(key1, key2, key3, tableName, value, fieldAction, dateInserted);
          //  AuditDataServices.Instance.InsertAudit(ConvertAudit(audit));
        }
    }
}
