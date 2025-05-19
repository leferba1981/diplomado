namespace Escenario02.Messages
{
    public class NotificationMobileMessage : INotificationMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS - Mensaje: {message}");
        }
    }
}