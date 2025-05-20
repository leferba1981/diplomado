using Escenario03.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario03.Model
{
    public class ChatUser : User
    {
        public ChatUser(IChatMediator mediator, string name) : base(mediator, name)
        {
        }

        public override async Task SendAsync(string message)
        {
            await Console.Out.WriteLineAsync($"{Name} está enviando un mensaje...");
            await _mediator.SendMessageAsync(message, this);
        }

        public override async Task ReceiveMessageAsync(string message, string from)
        {
            await Console.Out.WriteLineAsync($"{Name} recibe mensaje de {from}: {message}");
        }
    }
}
