using Escenario03.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario03.Model
{
    public class ChatRoom : IChatMediator
    {
        private readonly List<User> _users = new();

        public async Task RegisterUserAsync(User user)
        {
            _users.Add(user);
            await Console.Out.WriteLineAsync($"{user.Name} se ha unido al chat.");
        }

        public async Task SendMessageAsync(string message, User sender)
        {
            await Console.Out.WriteLineAsync($"\n{sender.Name} envía mensaje: {message}");

            // Distribuir el mensaje a todos los usuarios excepto al remitente
            var tasks = new List<Task>();
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    tasks.Add(user.ReceiveMessageAsync(message, sender.Name));
                }
            }

            // Esperar a que todos los mensajes sean entregados
            await Task.WhenAll(tasks);
        }
    }
}
