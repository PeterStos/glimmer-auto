using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace GlimmerAuto.Email
{
    public class EmailSender : IEmailSender
    {
        public EmailOptions Options { get; }

        public EmailSender(IOptions<EmailOptions> emailOptions)
        {
            Options = emailOptions.Value;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(Options.SendGridKey, subject, htmlMessage, email);
        }

        public Task Execute(string apiKey, string subject, string htmlMessage, string email)
        {
            //var client = new SendGridClient(Options.SendGridKey);
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                //From = new EmailAddress("admin@glimmer.com", "Glimmer Auto"),
                From = new EmailAddress("petersantos000@gmail.com", Options.SendGridUser),
                Subject = subject,
                PlainTextContent = htmlMessage,
                HtmlContent = htmlMessage
            };
            msg.AddTo(new EmailAddress(email));

            // Added as per Microsoft Instructions
            msg.SetClickTracking(false, false);

            // Send email with a try block
            try
            {
                return client.SendEmailAsync(msg);
            }
            catch ( Exception ex)
            {
            }
            return null;
        }
    }
}
