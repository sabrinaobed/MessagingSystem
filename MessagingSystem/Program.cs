using Microsoft.Extensions.DependencyInjection;
using MessagingSystem.Services;
using MessagingSystem.Interfaces;
using MessagingSystem.Controllers;
using MessagingSystem.Interfaces;
using MessagingSystem.Services;
using MessagingSystem.Controllers;


namespace MessagingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            // Register the services
            services.AddTransient<IMessagingService, EmailService>();
            services.AddTransient<MessageService>();
            services.AddTransient<MessagingController>();

            // Build the service provider
            var provider = services.BuildServiceProvider();
            var controller = provider.GetService<MessagingController>();

            // Send a message
            if (controller != null)
            {
                controller.SendMessageToUser("Alice", "Hello from Messaging System!");
            }
        }
     
    }
}
