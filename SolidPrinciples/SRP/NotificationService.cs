
namespace SolidPrinciples.SRP
{
    public class NotificationService
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
        public void ExecuteClass()
        {
            NotificationService service= new NotificationService();

            // email
            service.SendNotification("realahmetabdullah@gmail.com", "hello me", NotificationService.enNotificationType.Email);

            //sms
            service.SendNotification("+123456543", "Hi abdullah", enNotificationType.SMS);

            //fax
            service.SendNotification("123-2321", "hi abdullah in fax", enNotificationType.Fax);
        }

       

    }
}
