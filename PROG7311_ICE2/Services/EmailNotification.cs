namespace PROG7311_ICE2.Services
{
    public class EmailNotification : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
