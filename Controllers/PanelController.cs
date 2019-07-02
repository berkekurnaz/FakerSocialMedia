using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakerSocialMedia.DataAccessLayer.Concrete;
using FakerSocialMedia.Filter.Auth;
using FakerSocialMedia.Models;
using FakerSocialMedia.Utilites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FakerSocialMedia.Controllers
{
    public class PanelController : Controller
    {
        /* Add Operations This Page */
        UserOperations userOperations = new UserOperations("Users");
        RecordOperations recordOperations = new RecordOperations("Records");

        /* Add Utilities This Page */
        UserUtilities userUtilities = new UserUtilities();



        /* Control Panel Main Page */
        [AuthFilter]
        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetString("SessionId");

            int today = DateTime.Now.Day;
            int week = DateTime.Now.DayOfYear / 7;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            ViewBag.CountRecordByToday = recordOperations.GetAll().Where(x => x.CreatedDay == today && x.CreatedWeek == week && x.CreatedMonth == month && x.CreatedYear == year).Count();
            ViewBag.CountRecordByWeek = recordOperations.GetAll().Where(x => x.CreatedWeek == week && x.CreatedMonth == month && x.CreatedYear == year).Count();
            ViewBag.CountRecordByMonth = recordOperations.GetAll().Where(x => x.CreatedMonth == month && x.CreatedYear == year).Count();
            ViewBag.CountRecordsAll = recordOperations.GetAll().Count;

            ViewBag.CountRecordByFacebook = recordOperations.GetAll().Where(x => x.MediaName == "Facebook").Count();
            ViewBag.CountRecordByInstagram = recordOperations.GetAll().Where(x => x.MediaName == "Instagram").Count();
            ViewBag.CountRecordByTwitter = recordOperations.GetAll().Where(x => x.MediaName == "Twitter").Count();

            return View();
        }


        /* Control Panel Login Page */
        public IActionResult Login()
        {
            userUtilities.CreateDefaultUser(userOperations);
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var newUser = userOperations.Login(user);
            if (newUser != null)
            {
                HttpContext.Session.SetString("SessionUsername", newUser.Username);
                HttpContext.Session.SetInt32("SessionId", newUser.Id);
                return RedirectToAction("Index", "Panel");
            }
            return View(user);
        }

        /* Control Panel Logout Progress */
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        /* This Method Lists All Entries So Far */
        [AuthFilter]
        public IActionResult AllRecords(string mediaName)
        {
            var items = recordOperations.GetAll().Where(x => x.MediaName == mediaName);
            return View(items);
        }

        /* This Method Show Information By Record Id Number */
        [AuthFilter]
        public IActionResult RecordDetail(int Id)
        {
            var item = recordOperations.GetById(Id);
            if (item == null)
            {
                return RedirectToAction("Error", "Panel");
            }
            return View(item);
        }

        [AuthFilter]
        public IActionResult RecordDelete(int Id)
        {
            var item = recordOperations.GetById(Id);
            if (item == null)
            {
                return RedirectToAction("Error", "Panel");
            }
            return View(item);
        }

        /* This Method Delete Record By Id Number */
        [HttpPost]
        public IActionResult RecordDelete(int Id, IFormCollection collection)
        {
            var item = recordOperations.GetById(Id);
            recordOperations.DeleteModel(Id);
            return RedirectToAction("AllRecords", "Panel", new { mediaName = item.MediaName });
        }

        /* Control Panel HowToUse Page */
        [AuthFilter]
        public IActionResult HowToUse()
        {
            return View();
        }

        /* Control Panel Error Page */
        [AuthFilter]
        public IActionResult Error()
        {
            return View();
        }
    }
}