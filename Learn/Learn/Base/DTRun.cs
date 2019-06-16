using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Base
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
        public static Dictionary<string, string> GetListEnglishNameOfClass(List<string> lstName,Type T)
        {
            var dic = new Dictionary<string, string>();
            var vari = Attribute.GetCustomAttributes(T);
            foreach(PropertyInfo  pro in T.GetProperties())
            {
                foreach( Attribute i in pro.GetCustomAttributes(false))
                {
                    DisPlayAttribute dis = i as DisPlayAttribute;
                    if (dis != null)
                    {
                        if(lstName.Contains(dis.Name))
                        {
                            dic.Add(pro.Name, dis.Name);
                        }
                    }
                }
            }
            return dic;
        }


        #region GenrericPrivateClass
        static void GenrericPrivateClass()
        {
            var type = typeof(TestPrivateClass).GetNestedType("InnerClass", System.Reflection.BindingFlags.NonPublic);
            // create a new private object
            var obj = Activator.CreateInstance(type);
            // Create list
            var lst = DTRun.GenListGeneric(type);
            lst.Add(obj);

            Console.ReadKey();
        }
        #endregion

    }
    public class Test
    {
        [DisPlay(Name = "和我の")]
        public string Namibia { get; set; }
        [DisPlay(Name = "我是赌场")]
        public string API { get; set; }
        [DisPlay(Name = "我是赌场")]
        public string Pro { get; set; }

    }

}
