using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Base
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =false,Inherited =false)]
    public class DisPlayAttribute : Attribute
    {
        public string Name;
    }
}
