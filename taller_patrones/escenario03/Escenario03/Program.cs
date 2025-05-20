// See https://aka.ms/new-console-template for more information
using Escenario03.Interface;
using Escenario03.Model;

// Crear el mediador
IChatMediator chatRoom = new ChatRoom();

// Crear usuarios
User maria = new ChatUser(chatRoom, "María");
User juan = new ChatUser(chatRoom, "Juan");
User pedro = new ChatUser(chatRoom, "Pedro");
User lucia = new ChatUser(chatRoom, "Lucía");

// Registrar usuarios en el chat
await chatRoom.RegisterUserAsync(maria);
await chatRoom.RegisterUserAsync(juan);
await chatRoom.RegisterUserAsync(pedro);
await chatRoom.RegisterUserAsync(lucia);

// Enviar algunos mensajes
await maria.SendAsync("¡Hola a todos!");
await juan.SendAsync("Hola María, ¿cómo estás?");
await lucia.SendAsync("Bienvenida al grupo, María");
await pedro.SendAsync("¿Alguien quiere jugar un videojuego?");

Console.WriteLine("Presiona cualquier tecla para salir...");
Console.Read();