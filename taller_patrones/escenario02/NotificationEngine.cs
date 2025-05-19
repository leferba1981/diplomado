using Escenario02;
using Escenario02.Alerts;
using Escenario02.Confirmations;
using Escenario02.Messages;
using Escenario02.Warnings;

namespace Escenario02
{

    public class NotificationEngine
    {
        private INotificationAlert notificationAlert;
        private INotificationMessage notificationMessage;
        private INotificationWarning notificationWarning;
        private INotificationConfirmation notificationConfirmation;

        public NotificationEngine(INotificationFactory notificationFactory)
        {
            notificationAlert = notificationFactory.CreateAlert();
            notificationMessage = notificationFactory.CreateMessage();
            notificationWarning = notificationFactory.CreateWarning();
            notificationConfirmation = notificationFactory.CreateConfirmation();
        }

        public void SendNotification(string message)
        {
            notificationMessage.SendMessage(message);
            notificationAlert.SendAlert(message);
            notificationWarning.SendWarning(message);
            notificationConfirmation.SendConfirmation(message);
        }

    }
}