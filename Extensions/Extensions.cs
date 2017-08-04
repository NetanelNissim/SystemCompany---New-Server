using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        public static T MapTo<T>(this object source, T target)
        {
            var pis = source.GetType().GetProperties();
            foreach (var pi in pis)
            {
                var tgtPi = target.GetType().GetProperty(pi.Name);
                if (tgtPi != null && tgtPi.PropertyType.IsAssignableFrom(pi.PropertyType))
                {
                    tgtPi.SetValue(target, pi.GetValue(source));
                }
            }
            return target;
        }

    }
}
