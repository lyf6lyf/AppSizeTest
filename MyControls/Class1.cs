using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControls
{
    public class Class1
    {
        public static object O = CreateObject();

        public static object MyStaticProperty = CreateObject();

        public static object CreateObject()
        {
            Trace.WriteLine("Class1.CreateObject");
            return new Random().Next() > 0.5 ? new object() : new Random();
        }

        public object MyGetSet
        {
            get => MyStaticProperty;
            set => MyStaticProperty = value;
        }
    }
}
