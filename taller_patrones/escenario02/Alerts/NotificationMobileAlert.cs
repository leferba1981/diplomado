namespace Escenario02.Alerts
{
    public class NotificationMobileAlert : INotificationAlert
    {
        public void SendAlert(string alertMessage)
        {
            Console.WriteLine($"SMS - Alerta: {alertMessage}");
        }
    }
}