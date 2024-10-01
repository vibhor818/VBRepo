using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace n1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Method1();
            //Method2();
            //Console.WriteLine("I am the part of main method");
            //Method3();
            Add("Example");
            Add(112);

        }
        //static void DataConnection(SqlConnection cn)
        //{

        //}
        //static void DataConnection(Sqlite cn)
        //{

        //}
        //static void DataConnection(CosmosDB cn)
        //{

        //}
        static void Add(int a)
        {
            Console.WriteLine("This is method1" + a);
        }
        static void Add(string s)
        {
            Console.WriteLine("This is method2" + s);

        }
        static void Method3()
        {
            Console.WriteLine("This is method3");
        }
    }
}
