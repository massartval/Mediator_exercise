using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_exercise
{
    internal class Chat
    {
        private List<User> _users = new List<User>();
        internal void AddUser(User user)
        {
            _users.Add(user);
        }
        internal void Receive(User user, string message)
        {
            Console.WriteLine($"{user.Name} : {message}");
        }
    }
}
