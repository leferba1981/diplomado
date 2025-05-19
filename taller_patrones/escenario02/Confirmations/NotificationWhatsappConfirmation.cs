namespace Escenario02.Confirmations
{
    public class NotificationWhatsappConfirmation : INotificationConfirmation
    {
        public void SendConfirmation(string confirmationMessage)
        {
            Console.WriteLine($"WhatsApp - Confirmacion: {confirmationMessage}");
        }
    }
}