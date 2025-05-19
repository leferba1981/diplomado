namespace Escenario02.Messages
{
    public class NotificationDesktopMessage : INotificationMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Desktop - Mensaje: {message}");
        }
    }
}