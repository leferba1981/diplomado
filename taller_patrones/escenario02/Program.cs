using Escenario02;

public enum NotificationType
{
    Desktop,
    Web,
    Mobile,
    Whatsapp
};

public class Program
{

    static NotificationEngine ConfigureNotificationEngine(NotificationType notificationType)
    {
        switch (notificationType)
        {
            case NotificationType.Desktop:
                return new NotificationEngine(new DesktopFactory());
            case NotificationType.Web:
                return new NotificationEngine(new WebFactory());
            case NotificationType.Mobile:
                return new NotificationEngine(new MobileFactory());
            case NotificationType.Whatsapp:
                return new NotificationEngine(new WhatsappFactory());
            default:
                throw new Exception("Tipo de notificación no soportado");
        }
    }

    public static void Main()
    {
        // Instrucciones de nivel superior deben ir al final o al principio, pero no después de métodos o tipos.
        Console.WriteLine("Taller Patrones de Diseño - Escenario 02");

        Console.WriteLine("Seleccione el tipo de notificación:");
        Console.WriteLine("1. Desktop");
        Console.WriteLine("2. Web");
        Console.WriteLine("3. Mobile");
        Console.WriteLine("4. Whatsapp");

        int option = int.Parse(Console.ReadLine());

        NotificationType notificationType;
        switch (option)
        {
            case 1: notificationType = NotificationType.Desktop; break;
            case 2: notificationType = NotificationType.Web; break;
            case 3: notificationType = NotificationType.Mobile; break;
            case 4: notificationType =  NotificationType.Whatsapp; break;
            default: throw new Exception("Tipo no soportado");
        }
        ;
        NotificationEngine notificationEngine = ConfigureNotificationEngine(notificationType);
        Console.WriteLine("Ingrese el mensaje:");
        string message = Console.ReadLine() ?? string.Empty;

        notificationEngine.SendNotification(message);
    }
}