using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProgram
{
    public class Chat : IChatMediateur
    {
        private List<User> _users= new List<User>();

        public Chat()
        {
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(User user, string message)
        {
            string formatteMessage;
           
            if (user.UserName == "Vincent-Valery")
            {
                formatteMessage = "De Vincent-Valery" + message;
            }
            else
            {
                formatteMessage = "De Patric-Stanislas" + message;
            }

            Console.WriteLine("Le destinataire a envoyé le message suivant :");
            Console.WriteLine(formatteMessage);
        }

        
    }
}
