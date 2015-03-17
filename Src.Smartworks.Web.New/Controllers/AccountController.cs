using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Configuration;
using System.Globalization;
using System.Web;
using System.Web.Mvc;

namespace Src.Smartworks.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
 
            return View();
        }

         

        // GET: /Account/ForgotPassword
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
             
            return View();
        }

        // GET: /Account/ForgotPassword Success
        [AllowAnonymous]
        public ActionResult ForgotPasswordSuccess(string id)
        {
            
            return View( );
        }

        //
        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string id)
        {
 
            return View( );
        }

        //
        // GET: /Account/MyProfile
        [AllowAnonymous]
        public ActionResult MyProfile()
        {
            
            return View( );
        }

         
    }
}
