﻿using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IHelloService, HelloService>();
serviceCollection.AddSingleton<IMessageService, MessageService>(MessageService.ServiceConstruct);

var serviceProvider = serviceCollection.BuildServiceProvider();

var messageService = serviceProvider.GetRequiredService<IMessageService>();
Console.WriteLine(messageService.Message());
