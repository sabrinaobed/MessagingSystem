using MessagingSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingSystem.Controllers
{
    public class MessagingController
    {
        private readonly MessageService _messageService;

        public MessagingController(MessageService messageService)
        {
            _messageService = messageService;
        }

        public void SendMessageToUser(string recipient, string message)
        {
            _messageService.Send(recipient, message);
        }
    }
}
