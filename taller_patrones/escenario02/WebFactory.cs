using Escenario02.Messages;
using Escenario02.Alerts;
using Escenario02.Warnings;
using Escenario02.Confirmations;

namespace Escenario02
{
    public class WebFactory : INotificationFactory
    {
        public INotificationMessage CreateMessage()
        {
            return new NotificationWebMessage();
        }

        public INotificationAlert CreateAlert()
        {
            return new NotificationWebAlert();
        }

        public INotificationWarning CreateWarning()
        {
            return new NotificationWebWarning();
        }

        public INotificationConfirmation CreateConfirmation()
        {
            return new NotificationWebConfirmation();
        }        

    }
}