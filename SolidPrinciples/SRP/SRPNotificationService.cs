
namespace SRP.NotificationService
{
    public class SRPNotificationService
    {
        public enum enNotificationType { Email, SMS, Fax}
        public class EmailService
        {
            public static void SendEmail(string to, string message)
            {
                Console.WriteLine($"\nSending Email to {to}: {message}");
            }
        }

        public class SMSService
        {
            public static void SendSMS(string to, string message)
            {
                Console.WriteLine($"\nSending SMS to {to}: {message}");
            }
        }

        public class FaxService
        {
            public static void SendFax(string to, string message)
            {
                Console.WriteLine($"\nSending Fax to {to}: {message}");
            }
        }

        public void SendNotification(string to, string message, enNotificationType NotificationType)
        {
            if (NotificationType == enNotificationType.Email)
            {
                EmailService.SendEmail(to, message);
            }
            else if (NotificationType == enNotificationType.SMS)
            {
                SMSService.SendSMS(to, message);
            }
            else if (NotificationType == enNotificationType.Fax)
            {
                FaxService.SendFax(to, message);
            }
        }
        public static void ExecuteClass()
        {
            SRPNotificationService service= new SRPNotificationService();

            // email
            service.SendNotification("realahmetabdullah@gmail.com", "hello me", SRPNotificationService.enNotificationType.Email);

            //sms
            service.SendNotification("+123456543", "Hi abdullah", enNotificationType.SMS);

            //fax
            service.SendNotification("123-2321", "hi abdullah in fax", enNotificationType.Fax);
        }

       

    }
}
