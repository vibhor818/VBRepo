


using System.Data.SqlClient;

ExceptionHandleMethod();
Haha();

void Haha()
{
    throw new NotImplementedException();
}

Console.ReadLine();
void ExceptionHandleMethod()
{
    SqlConnection cn=null;

    try
	{
       cn= new SqlConnection("");
        cn.Open();
        int num1 = 10, num2 = 0, ans;
        ans = num1 / num2;
        Console.WriteLine(ans);
    }
	catch (SqlException ex)
	{

        Console.WriteLine(ex.Message);
    }
    catch(VibhorException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        //it will always execute
        //release the memory
        cn.Close();
        cn.Dispose();
    }
    
}
class VibhorException:Exception
{

}