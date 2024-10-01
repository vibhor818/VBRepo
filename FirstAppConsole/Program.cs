

//Console.WriteLine(Int16.MaxValue);
//Console.WriteLine(short.MaxValue);

//Console.WriteLine("====================");

//Console.WriteLine(Int32.MaxValue);
//Console.WriteLine(int.MaxValue);

//Console.WriteLine("====================");
//Console.WriteLine(Int64.MaxValue);
//Console.WriteLine(long.MaxValue);

//string name;
//Console.Write("Enter your name===> ");
//name=Console.ReadLine();//input method


using System.Text;
using System.Text.RegularExpressions;

//string age;
//Console.Write("Enter your age====>  ");
//age =Console.ReadLine();
//int ageAgain =Convert.ToInt32( age);//Exlicit Casting
//Console.WriteLine("Your name is==>  "+name+"   Your age is==>  "+ageAgain);//output method

//short num = 100;
//int numInt = num;//Implicit Casting
//long longNum = 200;
//numInt =(int)longNum;//Exlicit Casting

//int num1 = 10, num2 = 3, num3;
//num3 = num1 % num2;
//Console.WriteLine(num3);
//Console.WriteLine("Addition is=>  {0}  {1}  {2}",num3+" Values to add are ",num1,num2);

//var ageVar =Convert.ToInt32(age);
StringBuilder builder = new StringBuilder();
builder.Append("Hello  ");
builder.Append("How are you?");
Console.WriteLine(builder);


var textToTest = "hello world";
var regularExpression = "\\d";

var result = Regex.IsMatch(textToTest, regularExpression, RegexOptions.None);

if (result)
{
    Console.WriteLine("Yes this string has numeric value");
}
else
{
    Console.WriteLine("this string doesn't contain numeric value");
}



