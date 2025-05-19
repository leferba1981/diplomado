using Escenario02.Messages;
using Escenario02.Alerts;
using Escenario02.Warnings;
using Escenario02.Confirmations;

namespace Escenario02
{
    public class MobileFactory : INotificationFactory
    {
        public INotificationMessage CreateMessage()
        {
            return new NotificationMobileMessage();
        }

        public INotificationAlert CreateAlert()
        {
            return new NotificationMobileAlert();
        }

        public INotificationWarning CreateWarning()
        {
            return new NotificationMobileWarning();
        }

        public INotificationConfirmation CreateConfirmation()
        {
            return new NotificationMobileConfirmation();
        }
    }
}