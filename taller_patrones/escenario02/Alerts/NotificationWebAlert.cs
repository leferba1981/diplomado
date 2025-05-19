namespace Escenario02.Alerts
{
    public class NotificationWebAlert : INotificationAlert
    {
        public void SendAlert(string alertMessage)
        {
            Console.WriteLine($"Web - Alerta: {alertMessage}");
        }
    }
}