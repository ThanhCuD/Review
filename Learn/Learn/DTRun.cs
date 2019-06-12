using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class DTRun
    {
        public static IList GenListGeneric(Type type)
        {
            Type genericClass = typeof(List<>);
            Type constructedClass = genericClass.MakeGenericType(type);
            var instance = Activator.CreateInstance(constructedClass);
            return (IList)instance;
        }
    }
}
