## Patron de diseño
Creacional -> ABSTRACT FACTORY

## Interfaces
Ubicadas en la carpeta Interfaces:

- **INotificationMessage**: 
  - Método: `SendMessage(string message)`
  
- **INotificationAlert**: 
  - Método: `SendAlert(string alertMessage)`

- **INotificationWarning**: 
  - Método: `SendWarning(string warningMessage)`

- **INotificationConfirmation**: 
  - Método: `SendConfirmation(string confirmationMessage)`

## Alertas
El directorio `Alerts` contiene las clases que implementan `INotificationAlert`

- **NotificationDesktopAlert**: Alertas vía Desktop.
- **NotificationMobileAlert**: Alertas vía Celular (mensajes SMS).
- **NotificationWebAlert**: Alertas vía Web.
- **NotificationWhatsappAlert**: Alertas vía Whatsapp.

## Warnings
El directorio `Warnings` contiene las clases que implementan `INotificationWarning`

- **NotificationDesktopWarning**: Advertencias vía Desktop.
- **NotificationMobileWarning**: Advertencias vía Celular (mensajes SMS).
- **NotificationWebWarning**: Advertencias vía Web.
- **NotificationWhatsappWarning**: Advertencias vía Whastapp

## Confirmations
El directorio `Confirmations` contienen clases que implementan `INotificationConfirmation` 

- **NotificationDesktopConfirmation**: Confirmaciones vía Desktop.
- **NotificationMobileConfirmation**: Confirmaciones vía Celular (mensajes SMS).
- **NotificationWebConfirmation**: Confirmaciones vía Web.
- **NotificationWhatsappConfirmation**: Confirmaciones vía whatsapp.

## Factory
Para cada tipo de plataforma se implementaron las clases:
- **DesktopFactory**
- **MobileFactory**
- **WebFactory**
- **WhastappFactory**

## NotificationEngine
Es la clase cliente que se comunica por medio de las interfaces abstractas

## Program.cs
Implementación del patrón 