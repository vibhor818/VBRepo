


VBClass<int> vbInt=new VBClass<int>();

Console.WriteLine(vbInt.Call(112));


VBClass<string> vbString=new VBClass<string>();

Console.WriteLine(vbString.Call("Hello"));
public class VBClass<VB> //where VB:struct
{
  public VB Call(VB v)
    {
        return v;
    }
}
