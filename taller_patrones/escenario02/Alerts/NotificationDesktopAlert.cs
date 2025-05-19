namespace Escenario02.Alerts
{

    public class NotificationDesktopAlert : INotificationAlert
    {
        public void SendAlert(string alertMessage)
        {
            Console.WriteLine($"Desktop - Alerta: {alertMessage}");
        }
    }
}