

//TestOptional(f: 23.4, name:"Haha", num:900);


string number = "1234";
OutCallMethod(number);

int num=0;
void OutCallMethod(string number)
{
  if (!int.TryParse(number,out  num))
    {
        Console.WriteLine("string is==>  "+number);
    }
  else
    {
        Console.WriteLine("only integer is===> "+num);
    }
}

void TestOptional(string name,double f,int num=100)
{
    Console.WriteLine(name+"    "+f+"    "+num);
}