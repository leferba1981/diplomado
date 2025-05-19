namespace Escenario02.Warnings
{
    public class NotificationWhatsappWarning : INotificationWarning
    {
        public void SendWarning(string warningMessage)
        {
            Console.WriteLine($"WhatsApp - Advertencia: {warningMessage}");
        }
    }
}