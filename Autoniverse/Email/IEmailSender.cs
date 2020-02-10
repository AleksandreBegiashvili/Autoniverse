using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoniverse.Email
{
    public interface IEmailSender
    {
        // call Email with given information to users
        Task<SendEmailResponse> SendEmailAsync(string userEmail, string emailSubject, string message);
    }
}
