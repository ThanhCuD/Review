﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class TestPrivateClass
    {
        private class InnerClass
        {
            public string Name = "Name of Class";
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
}
