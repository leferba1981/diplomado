namespace Escenario02.Messages
{
    public class NotificationWebMessage : INotificationMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Web - Mensaje: {message}");
        }
    }
}