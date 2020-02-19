using System.Web.Mvc;
using EventManagement.Entity;
using EventManagement.DAL;
namespace EventManagement.MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserRepository users = new UserRepository();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignUp(UserDetails user)
        {
            users.AddUserDetails(user);
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
    }
}