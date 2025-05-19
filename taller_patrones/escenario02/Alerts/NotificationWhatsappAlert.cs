namespace Escenario02.Alerts
{
    public class NotificationWhatsappAlert : INotificationAlert
    {
        public void SendAlert(string alertMessage)
        {
            Console.WriteLine($"WhatsApp - Alerta: {alertMessage}");
        }
    }
}