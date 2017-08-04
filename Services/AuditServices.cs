using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class AuditServices
    {
        private static AuditServices instance;
        public static AuditServices Instance
        {
            get { return instance ?? (instance = new AuditServices()); }
        }

        public void InsertUser(int key1, int key2, int key3, string tableName, string value,
            string fieldAction, DateTime? dateInserted)
        {
            AuditPersister.Instance.InsertAudit(key1, key2, key3, tableName, value,
             fieldAction,  dateInserted);
        }
    }
}
