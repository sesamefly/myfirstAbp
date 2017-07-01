using MyFirstABP.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace MyFirstABP.Web.Host.Controllers
{
    public class AntiForgeryController : MyFirstABPControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}