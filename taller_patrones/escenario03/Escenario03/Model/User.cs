using Escenario03.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escenario03.Model
{
    public abstract class User
    {
        protected IChatMediator _mediator;
        public string Name { get; protected set; }

        protected User(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public abstract Task SendAsync(string message);
        public abstract Task ReceiveMessageAsync(string message, string from);
    }
}
