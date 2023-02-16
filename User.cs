using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_exercise
{
    internal class User
    {
        private Chat _chat;
        internal string Name { get; set; }
        public User(string name, Chat chat)
        {
            _chat = chat;
            Name = name;
        }

        internal void SendMessage(string message)
        {
            _chat.Receive(this, message);
        }
    }
}
