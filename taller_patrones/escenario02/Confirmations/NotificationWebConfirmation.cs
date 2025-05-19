namespace Escenario02.Confirmations
{
    public class NotificationWebConfirmation : INotificationConfirmation
    {
        public void SendConfirmation(string confirmationMessage)
        {
            Console.WriteLine($"Web - Confirmacion: {confirmationMessage}");
        }
    }
}