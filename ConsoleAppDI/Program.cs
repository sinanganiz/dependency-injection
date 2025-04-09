using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Register dependencies:
// When an IMessageSender is required, the container will provide an EmailSender instance.
// To switch to SmsSender, simply change the implementation here.
services.AddTransient<IMessageSender, EmailSender>();
services.AddTransient<NotificationService>();

var serviceProvider = services.BuildServiceProvider();

// Get an instance of NotificationService from the DI container.
// No need to manually instantiate it using 'new'.
var notifier = serviceProvider.GetRequiredService<NotificationService>();

notifier.Notify("Hello Dependency Injection!");