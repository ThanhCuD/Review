using Learn.Base;
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
       

    }
   

}
