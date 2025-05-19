using Escenario02.Messages;
using Escenario02.Alerts;
using Escenario02.Warnings;
using Escenario02.Confirmations;

namespace Escenario02
{
    public class DesktopFactory : INotificationFactory
    {
        public INotificationMessage CreateMessage()
        {
            return new NotificationDesktopMessage();
        }

        public INotificationAlert CreateAlert()
        {
            return new NotificationDesktopAlert();
        }

        public INotificationWarning CreateWarning()
        {
            return new NotificationDesktopWarning();
        }

        public INotificationConfirmation CreateConfirmation()
        {
            return new NotificationDesktopConfirmation();
        }
    }
}