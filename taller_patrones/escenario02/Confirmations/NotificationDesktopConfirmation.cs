namespace Escenario02.Confirmations
{
    public class NotificationDesktopConfirmation : INotificationConfirmation
    {
        public void SendConfirmation(string confirmationMessage)
        {
            Console.WriteLine($"Desktop - Confirmacion: {confirmationMessage}");
        }
    }
}