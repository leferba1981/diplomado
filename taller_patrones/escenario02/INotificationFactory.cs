using Escenario02;
using Escenario02.Alerts;
using Escenario02.Messages;
using Escenario02.Warnings;
using Escenario02.Confirmations;

namespace Escenario02
{
    public interface INotificationFactory
    {
        INotificationMessage CreateMessage();
        INotificationAlert CreateAlert();
        INotificationWarning CreateWarning();
        INotificationConfirmation CreateConfirmation();
    }
}