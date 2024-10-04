

public delegate void VBEventHandler(object sender);

public class Program
{
    public static void Main(string[] args)
    {
        VBButton btn = new VBButton();
        btn.Click += EventMethod;//subscribing event
        btn.OnClick("VB");
    }
      
        public static void EventMethod(object sender)
        {
            Console.WriteLine("I have been clicked by " + sender);
        }

    }


public class VBButton
{
    public event VBEventHandler Click;
    public void OnClick(object sender)
    {
        Click(sender);//raising an event
    }

}