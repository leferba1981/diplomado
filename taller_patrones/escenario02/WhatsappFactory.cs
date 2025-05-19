using Escenario02.Messages;
using Escenario02.Alerts;
using Escenario02.Warnings;
using Escenario02.Confirmations;

namespace Escenario02
{
    public class WhatsappFactory : INotificationFactory
    {
        public INotificationMessage CreateMessage()
        {
            return new NotificationWhatsappMessage();
        }

        public INotificationAlert CreateAlert()
        {
            return new NotificationWhatsappAlert();
        }

        public INotificationWarning CreateWarning()
        {
            return new NotificationWhatsappWarning();
        }

        public INotificationConfirmation CreateConfirmation()
        {
            return new NotificationWhatsappConfirmation();
        }
    }
}