using System.Data.SqlClient;

MakeMoreHeavy mh = new MakeMoreHeavy();
//HeavyClass hc = new HeavyClass(mh);
//hc.Call();
//hc.Dispose();
using (HeavyClass hc = new HeavyClass(mh))
{
    hc.Call();
    //hc.Dispose();//automatically executes when you use using with Idisposable object
}
class HeavyClass:IDisposable
{
    bool isDisposed = true;
    MakeMoreHeavy mh1=null;
    SqlConnection cn=null;
    public HeavyClass(MakeMoreHeavy mh)
    {
        mh = mh1;
    }
    public void Call()
    {
        using(SqlConnection cn=new SqlConnection())
        {
            cn.Open();

            //cn.Close();
        }
        Console.WriteLine("Big logic");
    }
    private  void Dispose(bool disposing)
    {
        if (disposing==true)
        {
            //release the memories of the object which you have used
            mh1 = null;
            cn = null;
            Console.WriteLine("I've been disposed");
        }
    }
    public virtual void Dispose()
    {
        Dispose(true);
    }
}
class MakeMoreHeavy
{
    
}
