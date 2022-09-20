using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControls
{
    public static class Class2
    {
        public static object O = CreateObject(typeof(Class2).ToString());

        public static object CreateObject(string s)
        {
            return new Random().Next() > 0.5 ? new object() : new Random();
        }
    }
}
