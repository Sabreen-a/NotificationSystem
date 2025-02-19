using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NotificationSystem;
using Serilog;

class Program
{
    static void Main()
    {
        
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        try
        {
           
            var settings = ConfigLoader.LoadSettings();

           
            UserService userService = new UserService();
            EmailNotifier emailNotifier = new EmailNotifier(settings);

           //register emailnotifier subscriber
            userService.OnUserRegistered += emailNotifier.SendEmail;

          
            userService.RegisterUser("SabreenAshraf", "sabreenashraf25793@gmail.com");
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error");
        }
        finally
        {
            Log.CloseAndFlush(); 
        }
    }
}

