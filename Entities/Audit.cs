using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Audit
    {
        public Audit(int key1 , int key2, int key3 , string tableName , string value,
           string fieldAction, DateTime? dateInserted)
        {
            this.TableName = tableName;
            this.Value = value;
            this.Key1 = key1;
            this.Key2 = key2;
            this.Key3 = key3;
            this.FieldAction = fieldAction;
            this.DateInserted = dateInserted;
        }

        public Audit()
        {
            // TODO: Complete member initialization
        }

        public string TableName { get; set; }
        public string Value { get; set; }
        public int Key3 { get; set; }
        public int Key2 { get; set; }
        public int Key1 { get; set; }
        public string FieldAction { get; set; }
        public DateTime? DateInserted { get; set; }

    }
}
