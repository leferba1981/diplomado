namespace Escenario02.Messages
{
    public class NotificationWhatsappMessage : INotificationMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Whatsapp - Mensaje: {message}");
        }
    }
}