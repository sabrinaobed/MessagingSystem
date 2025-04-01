using MessagingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingSystem.Services
{
   public class MessageService
   {
        private readonly IMessagingService _messagingService;

        //Constructor that takes an IMessagingService - this is DI
        public MessageService(IMessagingService messagingService)
        {
            _messagingService = messagingService;
        }

        //Method to send a message using the injected service
        public void Send(string recipient, string message)
        {
            if (string.IsNullOrEmpty(recipient) || string.IsNullOrEmpty(message))
            {
                Console.WriteLine("Error: Recipient and message cannot be empty.");
                return;
            }

            _messagingService.SendMessage(recipient, message);
            Console.WriteLine("Message sent successfully!");
        }

    }
}
