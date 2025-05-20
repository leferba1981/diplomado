using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escenario03.Model;

namespace Escenario03.Interface
{
    public interface IChatMediator
    {
        Task RegisterUserAsync(User user);
        Task SendMessageAsync(string message, User sender);
    }
}
