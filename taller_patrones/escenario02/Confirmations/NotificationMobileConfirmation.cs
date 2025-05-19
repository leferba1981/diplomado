namespace Escenario02.Confirmations
{
    public class NotificationMobileConfirmation : INotificationConfirmation
    {
        public void SendConfirmation(string confirmationMessage)
        {
            Console.WriteLine($"SMS - Confirmacion: {confirmationMessage}");
        }
    }
}