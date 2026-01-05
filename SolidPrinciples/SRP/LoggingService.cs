public class LoggingService
{
    public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

    public void Log(string message, enLoggingType LoggingType)
    {

        if (LoggingType == enLoggingType.ToFile)
        {
            FileLoggingService.Log(message);
        }
        else if (LoggingType == enLoggingType.ToEventLog)
        {
            EventLogService.Log(message);
        }
        else if (LoggingType == enLoggingType.ToDatabase)
        {
            DatabaseLoggingService.Log(message);
        }
    }



public class FileLoggingService
{
    public static void Log(string message)
    {
        Console.WriteLine($"\nLog to file: {message}");
    }
}

public class EventLogService
{
    public static void Log(string message)
    {
        Console.WriteLine($"\nLog to Event Log: {message}");
    }
}

public class DatabaseLoggingService
{

    public static void Log(string message)
    {
        Console.WriteLine($"\nLog to Database: {message}");
    }
}


    public void ExecuteClass()
    {
    
        LoggingService LoggingService = new LoggingService();

        LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToFile);

        LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToEventLog);

        LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToDatabase);

        Console.ReadKey();

    
    }
}