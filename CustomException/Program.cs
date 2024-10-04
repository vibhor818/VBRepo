



try
{
    throw new VibhorException("Vibhor Exception Handler");
}
catch (VibhorException vb)
{

    Console.WriteLine(vb.Message);
}


public class VibhorException:Exception
{
    string _msg;
    public VibhorException(string msg):base(msg)
    {
        Console.WriteLine("Haha exception handled by "+msg);
    }
}
