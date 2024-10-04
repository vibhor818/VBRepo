using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoinQuery
{
    class Order
    {
        private int _OrderID;
        private int _CustomerID;
        private double _Cost;
        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }
        public int CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        public double Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }
    }


    class Customer
    {
        private int _CustomerID;
        private string _Name;
        private string _Email;
        public int CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Customers = new List<Customer> {
                    new Customer {
                        CustomerID = 7,
                        Name = "Emma",
                        Email = "emz0r@worreva.com"
                    },
                    new Customer {
                        CustomerID = 84,
                        Name = "Pedro",
                        Email = "pedro@cerveza.es"
                    },
                     new Customer {
                        CustomerID = 7,
                        Name = "Joe",
                        Email = "joe@gmail.com"
                    },
                    new Customer {
                        CustomerID = 102,
                        Name = "Vladimir",
                        Email = "vladimir@pivo.ru"
                    }
                };

            var Orders = new List<Order> {
                         new Order {
                             OrderID = 1,
                             CustomerID = 84,
                             Cost = 159.12
                         },
                         new Order {
                             OrderID = 2,
                             CustomerID = 7,
                             Cost = 18.50
                         },
                         new Order {
                             OrderID = 3,
                             CustomerID = 84,
                             Cost = 2.89
                         }
                     };

            var Found = from o in Orders
                        join c in Customers on o.CustomerID equals c.CustomerID
                        select new { c.Name, o.OrderID, o.Cost };
            // Display results.
            Console.WriteLine("----------Join Command-------------");
            foreach (var Result in Found)
                Console.WriteLine(Result.Name + " spent " +
                    Result.Cost.ToString() + " in order " +
                    Result.OrderID.ToString());

            //getting value from multiple classes. It is possible to write a query that gets every combination of the objects from two collections. This is achieved by using the "from" keyword multiple times. 
            var Found1 = from o in Orders
                         from c in Customers
                         select new { c.Name, o.OrderID, o.Cost };

            Console.WriteLine();
            foreach (var res in Found1)
            {
                Console.WriteLine(res.Name + " Order Id " + res.OrderID + " Cost is " + res.Cost.ToString());
            }
            Console.WriteLine("-----------Join by CustomerID--------------");
            Console.WriteLine();
            //In the above you are getting value multiple times
            var Found2 = from o in Orders
                         from c in Customers
                         where o.CustomerID == c.CustomerID
                         select new { c.Name, o.OrderID, o.Cost };
            Console.WriteLine();
            foreach (var res in Found2)
            {
                Console.WriteLine(res.Name + " Order Id " + res.OrderID + " Cost is " + res.Cost.ToString());
            }



            //Grouping
            Console.WriteLine();
            Console.WriteLine("-----------Grouping--------------------");
            var OrdersByCustomer = from o in Orders
                                   group o by o.CustomerID;
            // Iterate over the groups.
            foreach (var Cust in OrdersByCustomer)
            {
                // About the customer...
                Console.WriteLine("Customer with ID " + Cust.Key.ToString() +
                    " ordered " + Cust.Count().ToString() + " items.");
                // And what they ordered.
                foreach (var Item in Cust)
                    Console.WriteLine("    ID: " + Item.OrderID.ToString() +
                        " Cost: " + Item.Cost.ToString());
            }

            //Filtering
            Console.WriteLine("------------Filtering-------------");
            Console.WriteLine();
            var OrderCounts = from o in Orders
                              group o by o.CustomerID into g
                              select new
                              {
                                  CustomerID = g.Key,
                                  TotalOrders = g.Count()
                              };

            foreach (var Item in OrderCounts)
                Console.WriteLine("    ID: " + Item.CustomerID.ToString() +
                    " Cost: " + Item.TotalOrders.ToString());


            var sortedCustomer = from c in Customers
                                 orderby c.CustomerID
                                 select c;
            Console.WriteLine("----------Order By CustomersID-------------");
            Console.WriteLine();
            foreach (var k in sortedCustomer)
            {
                Console.WriteLine("   ID   " + k.Name);
            }


            Console.WriteLine();
            Console.WriteLine("-------Maximum------------");
            var maxID = (from c1 in Customers
                         select c1.CustomerID).Max();
            Console.WriteLine(maxID.ToString());

            Console.WriteLine();
            Console.WriteLine("-------Minimum------------");
            var minID = (from c1 in Customers
                         select c1.CustomerID).Min();
            Console.WriteLine(minID.ToString());

            Console.WriteLine();
            Console.WriteLine("------Count------------");
            var count = (from c1 in Customers
                         select c1.CustomerID).Count();
            Console.WriteLine(count.ToString());

            Console.WriteLine();
            Console.WriteLine("------Distinct------------");
            var dictinct = (from c1 in Customers
                            select c1.CustomerID).Distinct();


            foreach (var g in dictinct)
            {
                Console.WriteLine(g);
            }


        }


    }
}


