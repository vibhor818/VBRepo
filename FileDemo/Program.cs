using System.Data;
using System.IO;
using System.Reflection;

string fileName = @"C:\Check\Sample\oct.txt";
string folderName = @"C:\Check\Sample\Test";
//CreateFileMethod(fileName);
//WriteContentInFile(fileName);
//CreateFolder(folderName);
CollectFileInformation(fileName);

void CollectFileInformation(string fileName)
{
    Console.WriteLine(Path.GetDirectoryName(fileName));
    Console.WriteLine(Path.GetExtension(fileName));
    Console.WriteLine(Path.GetFileNameWithoutExtension(fileName));
}

void CreateFolder(string folderName)
{
   if(!Directory.Exists(folderName))
    {
        Directory.CreateDirectory(folderName);
    }
}

void WriteContentInFile(string fileName)
{
    string[] data = new string[] { "This is my data", "second data" };
    File.WriteAllLines(fileName, data);
    Console.WriteLine("File has been written.");
}

void CreateFileMethod(string fileName)
{
    if (!File.Exists(fileName))
    {
        File.Create(fileName);
        Console.WriteLine("File has been created.");
    }
}