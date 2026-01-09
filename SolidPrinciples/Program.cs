using OCP.NotificationService;
using SRP.NotificationService;
public class Program
{
    public static void Main(string[] args)
    {
        // SRP
        SRPNotificationService.ExecuteClass();
       // Open closed 
       OCPNotificationService.ExecuteClass();
        // LCP
        LSPPersonService.ExecuteClass();
    }
}

