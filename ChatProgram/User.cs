using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProgram
{
    public class User : IUser
    {
        public List<User> users { get; set; }
        private string _userName { get; set; }
        private IChatMediateur _chatMediateur;
        
        public User(string userName, IChatMediateur chatMediateur)
        {
            _userName = userName;
            _chatMediateur = chatMediateur;
        }
        public string UserName { get { return _userName;} }
        //public void Receive()
        //{
        //    string message = "Salut. TU - VAS - BIEN ???? (les Inconnus dans Auteil Neuilly Passy";
        //    Mediateur.Instance.Send(message);
            
        //}

        public void ReceiveMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void SendMessage(string message)
        {
            _chatMediateur.SendMessage(this, message);
        }
    }
}

