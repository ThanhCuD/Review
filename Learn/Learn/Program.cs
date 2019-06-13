using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<string>()
            {
                "我是赌场", "我是赌场","和我の"
            };
            Console.OutputEncoding = Encoding.UTF8;
           var dic =  DTRun.GetListEnglishNameOfClass(lst,typeof(Test));
            foreach(var i in dic)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            
            Console.ReadLine();
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
