using OCP.NotificationService;
using SRP.NotificationService;
public class Program
{
    public static void Main(string[] args)
    {
     
        SRPNotificationService.ExecuteClass();   // SRP
      
        OCPNotificationService.ExecuteClass(); // Open closed 
        
        LSPPersonService.ExecuteClass(); // LCP

        ISPDeviceService.ExecuteClass(); // ISP
    }
}

