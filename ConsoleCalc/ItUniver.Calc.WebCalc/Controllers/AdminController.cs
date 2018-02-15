using ItUniver.Calc.DB.Models;
using ItUniver.Calc.DB.NH.Repositories;
using ITUniver.Calc.DB.NH.Repositories;
using System.Linq;
using System.Web.Mvc;

namespace WebCalc.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IUserRepository Users { get; set; }

        public AdminController()
        {
            Users = new NhUserRepository();
        }

        // GET: Manage
        public ActionResult Index()
        {
            var users = Users.GetAll()
                .Where(u => u.Status != UserStatus.Deleted);
            return View(users);
        }

        public ActionResult Delete(long id)
        {
            var user = Users.Find(id);
            if (user != null)
            {
                user.Status = UserStatus.Deleted;
                Users.Save(user);
            }
            return RedirectToAction("Index");
        }

    }
}