
using Serilog;
using System;
using System.Net;
using System.Net.Mail;

namespace NotificationSystem
{
    class EmailNotifier
    {

        EmailSettings _emailSettings = null;
        public EmailNotifier(EmailSettings emailSettings)
        {
            
            _emailSettings = emailSettings;
        }
        public void SendEmail(string username, string email)
        {
            Log.Logger = new LoggerConfiguration()
            
            .WriteTo.File("logs/errors.log", rollingInterval: RollingInterval.Day) 
            .CreateLogger();

            try
            {
                using (SmtpClient client = new SmtpClient(_emailSettings.SmtpServer, _emailSettings.SmtpPort))
                {
                    client.Credentials = new NetworkCredential(_emailSettings.EmailFrom, _emailSettings.AppPassword);
                    client.EnableSsl = true;

                    MailMessage mailMessage = new MailMessage
                    {
                        From = new MailAddress(_emailSettings.EmailFrom),
                        Subject = "Verfifcation Mail!",
                        Body = "Hello! This is a test email from C# Console App using Gmail SMTP.",
                        IsBodyHtml = false
                    };

                    mailMessage.To.Add(email);

                    client.Send(mailMessage);
                    Console.WriteLine("Email sent successfully via Gmail SMTP!");
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "خطأ حدث أثناء تشغيل التطبيق.");
            }
            finally
            {
                Log.CloseAndFlush(); 
            }



        }
        

    
}
}
