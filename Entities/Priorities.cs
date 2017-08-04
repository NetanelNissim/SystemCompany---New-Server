using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Priorities
    {
        public Priorities(string TypePriority, int IdPriority)
        {
            this.TypePriority = TypePriority;
            this.idPriority = IdPriority;
        }

        public Priorities(string TypePriority)
        {
            this.TypePriority = TypePriority;
        }

        public Priorities(){ }

        public Priorities(int IdPriority)
        {
            this.idPriority = IdPriority;
        }

        public string TypePriority { get; set; }
        public int idPriority { get; set; }
    }
}
