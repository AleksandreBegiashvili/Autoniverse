using Autoniverse.Email.EmailService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoniverse.Email
{
    public static class SendGridExtensions
    {
        // This is the same thing that you do in startup class, but separated 
        public static IServiceCollection AddSendGridEmailSender(this IServiceCollection services)
        {
            services.AddTransient<IEmailSender, SendGridEmailSender>();

            return services;
        }
    }
}
