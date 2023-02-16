using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProgram
{
    internal class Mediateur
    {
        private static Mediateur? _instance;
        public static Mediateur Instance
        {
            get { return _instance ??= new Mediateur(); }
        }
        private Action<string> _action;

        private Mediateur()
        {

        }
        public void Register(Action<string> action)
        {
            _action += action;
        }
        public void Send(string message)
        {
            _action.Invoke(message);
        }
    }
}
