

string fileName = @"C:\Check\Sample\octTest.txt";

//WriteStream(fileName);
ReadStream(fileName);

void ReadStream(string fileName)
{
    Stream s = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    StreamReader sr=new StreamReader(s);
    Console.WriteLine(sr.ReadToEnd());
    sr.Close();
   // sr.Dispose();
}

void WriteStream(string fileName)
{
    Stream s = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
    StreamWriter sw = new StreamWriter(s);
    sw.WriteLine("I am stream data");
    sw.Close();
    sw.Dispose();
}