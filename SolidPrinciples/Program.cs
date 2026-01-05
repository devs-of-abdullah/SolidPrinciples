using SolidPrinciples.SRP;

public class Program
{
    public static void Main(string[] args)
    {
        NotificationService service = new NotificationService();
        service.ExecuteClass();
    }
}
