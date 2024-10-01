
using System.Diagnostics.Contracts;

ChatModule chat=new ChatModule();
chat.senderName = "john";
chat.senderMsg = "How are you?";
chat.SendMessage();
Console.WriteLine("=========================");
ChatFunctions chatTest=new ChatFunctions();
chatTest.senderName = "john";
chatTest.senderMsg = "Test";
chatTest.SendMessage();
public struct ChatModule//They get memory on stack fast
{
    public int NoOfTimes;
    public string senderName;
    public string senderMsg;
    public ChatModule()//Constructor
    {
        NoOfTimes = 10;senderName = "Haha";senderMsg = "Check";
        Console.WriteLine("I am chat module");
    }
    public void SendMessage()
    {
        Console.WriteLine("Sender Name is==>  " + senderName + "  msg is==>  " + senderMsg);
    }
}
public class ChatFunctions//They get memory on heap expensive
{
    
    public int NoOfTimes;
    public string senderName;
    public string senderMsg;
    public ChatFunctions()
    {
        Console.WriteLine("I am chat function class");
    }
    public void SendMessage()
    {
        Console.WriteLine("Sender Name is==>  "+senderName+"  msg is==>  "+senderMsg);
    }
}