
using bussiness.interfaces;
using bussiness.services;
using presentaiton.consoleApp.Dialogs;





var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<IFileService>(new FileService("users.json"));
serviceCollection.AddSingleton<IUserService, UserService>();
serviceCollection.AddSingleton<MenuDialogs>();

var serviceProvider = serviceCollection.BuildServiceProvider();
var menuDialogs = serviceProvider.GetRequiredService<MenuDialogs>();

