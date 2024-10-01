using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBNamespace;

namespace TestName
{
    class Program
    {
        static void Main(string[] args)
        {
            IAmOtherNamespaceMember obj = new IAmOtherNamespaceMember();
            Console.WriteLine(obj.Call());
            var unknown = "Test";

            
        }
    }
}

