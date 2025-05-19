namespace Escenario02.Warnings
{
    public class NotificationDesktopWarning : INotificationWarning
    {
        public void SendWarning(string warningMessage)
        {
            Console.WriteLine($"Desktop - Advertencia: {warningMessage}");
        }
    }
}