
using System.Diagnostics;
using Microsoft.Extensions.Logging.EventLog;
using static System.Net.Mime.MediaTypeNames;
CallDebugMethod();

void CallDebugMethod()
{
    
    //Debug.WriteLine("I am in the starting call debug  method");
    //Console.WriteLine(  "This is my method");
    //Debug.WriteLine("I am in end of call debug  method");
  
   
    using (EventLog _log = new EventLog("Application"))
    {
        _log.Source = "Application";
        _log.WriteEntry("Vibhor Second Message", EventLogEntryType.Information, 101, 1);
        Console.WriteLine("Log has been saved");
    }
}