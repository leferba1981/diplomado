namespace Escenario02.Warnings
{
    public class NotificationMobileWarning : INotificationWarning
    {
        public void SendWarning(string warningMessage)
        {
            Console.WriteLine($"SMS - Advertencia: {warningMessage}");
        }
    }
}