using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingSystem.Interfaces
{
    public interface IMessagingService
    {
        void SendMessage(string recipient, string message);
    }
}
