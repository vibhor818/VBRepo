
//int n1 = 12;
//string str1 = "Check";
//FirstMethod();
//ParametrizedMethod(n1,str1);
////int ans = Add(30, 50);
//Console.WriteLine(Add(30, 50));


int num = 100;
CallMethod(num);
Console.WriteLine("num in main method is==>  "+num);

void CallMethod(int a)
{
    Console.WriteLine("value in call method is == > "+a);
    num = 900;
}

void FirstMethod()
{
    int d = 10;
    Console.WriteLine("This is first method");
}
void ParametrizedMethod(int n,string str)
{
    
    Console.WriteLine("value of n is===>  "+n+"  value of str is==>  "+str);
}
object Add(int a,int b)
{
    int ans = a + b;
    return ans;
}