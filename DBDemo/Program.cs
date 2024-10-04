
using DBDemo.Models;
using DBDemo.Services;

EmpContext context=new EmpContext();

var data=context.Emp.ToList();//select * from emp

//foreach (Emp item in data)
//{
//    Console.WriteLine(item.Id+"   "+item.Name+"   "+item.Address);
//}
//Console.WriteLine("===========INSERT==============");
//Emp john=new Emp();
////john.Id = 11;
//john.Name = "JOhnRembo";
//john.Address = "France";

//context.Emp.Add(john);
//context.SaveChanges();//will save data in database
//var data1 = context.Emp.ToList();//select * from emp

//foreach (Emp item in data1)
//{
//    Console.WriteLine(item.Id + "   " + item.Name + "   " + item.Address);
//}