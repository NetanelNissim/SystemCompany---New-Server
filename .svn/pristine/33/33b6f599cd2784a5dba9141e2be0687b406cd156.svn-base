using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public abstract class BaseObject
    {
        protected BaseObject(Guid id)
        {
            this.id = id;
        }

        protected BaseObject()
        {
            this.id = Guid.NewGuid();
        }

        private readonly Guid id;
        public Guid Id
        {
            get { return id; }
        }
    }
}
