namespace Escenario02.Warnings
{
    public class NotificationWebWarning : INotificationWarning
    {
        public void SendWarning(string warningMessage)
        {
            Console.WriteLine($"Web - Advertencia: {warningMessage}");
        }
    }
}