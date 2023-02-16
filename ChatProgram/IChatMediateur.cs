using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProgram
{
    public interface IChatMediateur
    {
        void SendMessage(User user, string message);
        void AddUser(User user);
    }
}
