using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserRegistrationMVCcore.Models;
namespace UserRegistrationMVCcore.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly ApplicationUserClass _auc;
        public UserRegistrationController(ApplicationUserClass auc)
        {
            _auc = auc;
        }

        public ActionResult Index()
        {

            return View(_auc.UserReg1.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserClass uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The User " + uc.Username + "is saved successfully";
            return View();
        }
        public ActionResult Edit(int id)
        {

            var row = _auc.UserReg1.Where(model => model.UserId == id).FirstOrDefault();
            return View(row);

        }

        [HttpPost]
        public ActionResult Edit(UserClass s)
        {

            _auc.Entry(s).State = EntityState.Modified;
            int a = _auc.SaveChanges();
            if (a > 0)
            {

                ViewBag.UpdateMessage = "Data updated";

            }
            return View();
        }

        public ActionResult Delete(int id)
        {

            var delrow = _auc.UserReg1.Where(model => model.UserId == id).FirstOrDefault();
            return View(delrow);

        }

        [HttpPost]
        public ActionResult Delete(UserClass s)
        {

            _auc.Entry(s).State = EntityState.Deleted;
            int a = _auc.SaveChanges();
            if (a > 0)
            {

                TempData["DeleteMessage"] = "Data deleted";
            }
            return View();
        }
    }
}
