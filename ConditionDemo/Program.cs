


int[,] arr=new int[3,3];

for(int i=0; i<3; i++)
{
    for(int j=0; j<3; j++)
    {
        Console.Write("Enter the value==>  ");
        arr[i,j] =Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("=========================");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine();
    Console.WriteLine();
    for (int j = 0; j < 3; j++)
    {
        Console.Write("      "+ arr[i, j]);
         
    }
}







//int[] arr = new int[3];
//arr[0] = 1;
//arr[1] = 56;
//arr[2] = 90;

//string[] items=new string[3];
//items[0] = "Toffee";
//items[1] = "Coffee";
//items[2] = "Chocolates";

//foreach(string item in items)
//{
//    Console.WriteLine(item);
//}






//while (i<=10)
//{
//    Console.WriteLine("The countig is==>  "+i);
//    i = i + 3;
//   // i++;
//}

//for (int i = -10; i >0 ; i--)
//{
//    Console.WriteLine("The countig is==>  " + i);
//}
//int i = 1;
//do
//{
//    Console.WriteLine("Value is ==>  "+i);
//    i++;
//} while (i<=10);










//int num = 1;

//switch (num)
//{
//	case 'a':
//        Console.WriteLine("Your pressed 1");
//        break;
//    case 2:
//        Console.WriteLine("Your pressed 2");
//        break;
//    case 3:
//        Console.WriteLine("Your pressed 3");
//        break;
//    default:
//        Console.WriteLine("Please press 1,2 or 3");
//        break;
//}


//char ch = 'p';
//if (ch == 'y' || ch =='Y')
//{
//    Console.WriteLine("Just check me. ");
//    Console.Write("yes it is same value");
//}
//else if(ch=='z')
//{
//    Console.WriteLine("it is z character");
//}
//else
//{
//    Console.WriteLine("neither it is y nor z");
//}
Console.ReadLine();

