namespace OCP.NotificationService
{
    public class OCPNotificationService
    {
        private INotification _Notification;

        public OCPNotificationService(INotification Notification)
        {
            _Notification = Notification;
        }

        public void SendNotification(string to, string message)
        {


            _Notification.Send(to, message);


        }



        public interface INotification
        {
            public void Send(string to, string message);
        }


        public class EmailService : INotification
        {
            public void Send(string to, string message)
            {
                Console.WriteLine($"\nSending Email to {to}: {message}");
            }

        }

        public class SMSService : INotification
        {
            public void Send(string to, string message)
            {
                Console.WriteLine($"\nSending SMS to {to}: {message}");
            }
        }

        public class FaxService : INotification
        {
            public void Send(string to, string message)
            {
                Console.WriteLine($"\nSending Fax to {to}: {message}");
            }
        }

        public class TelegramService : INotification
        {
            public void Send(string to, string message)
            {
                Console.WriteLine($"\nSending Telegram to {to}: {message}");
            }
        }


        public class WhatsappService : INotification
        {
            public void Send(string to, string message)
            {
                Console.WriteLine($"\nSending Whatsapp to {to}: {message}");
            }
        }


        

        public static void ExecuteClass()
        {
            OCPNotificationService notificationService = new OCPNotificationService(new EmailService());

            notificationService.SendNotification("Abdullah@example.com", "Welcome to our service!");

            notificationService = new OCPNotificationService(new SMSService());

            notificationService.SendNotification("+123456789", "Your OTP code is 1234.");

            notificationService = new OCPNotificationService(new FaxService());

            notificationService.SendNotification("123-456-789", "Fax Message: Important document.");

            notificationService = new OCPNotificationService(new TelegramService());

            notificationService.SendNotification("123-456-789", "Telegram Message: Important message.");

            notificationService = new OCPNotificationService(new WhatsappService());

            notificationService.SendNotification("123-456-789", "Whatsapp Message: Important message.");



        }
    }
}