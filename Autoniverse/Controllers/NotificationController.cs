using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Autoniverse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        [HttpGet]
        //[Produces("text/plain")]
        public IActionResult GetEmailConfirmationPage(string userId, string code)
        {

            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(code))
            {
                return BadRequest(new { EmailConfirmed = false });

            }

            return Ok(new { EmailConfirmed = true });

            //string htmlContent = "<div class=\"card\">" +
            //    "<div  class=\"box\">" +
            //    " <div class=\"img\">" +
            //    "<!--<img src=\"~/ images / logo.png\">-->" +
            //    " </div>" +
            //    "<h2>Thank You<br><span>Email Confirmed</span></h2>" +
            //    "<p>" +
            //    " You can now successfuly login. You have full access to our products and services." +
            //    "</p>" +
            //    "<a class=\"btn btn-primary btn - block\" [routerLink]=\"['/login']\" >LOGIN</a>" +
            //    " </div>" +
            //    "</div>";

            //return new ContentResult
            //{
            //    ContentType = "text/html",
            //    StatusCode = (int)HttpStatusCode.OK,
            //    Content = htmlContent
            //};

        }
    }
}