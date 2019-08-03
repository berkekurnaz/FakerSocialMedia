using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakerSocialMedia.DataAccessLayer.Concrete;
using FakerSocialMedia.Models;
using Microsoft.AspNetCore.Mvc;

namespace FakerSocialMedia.Controllers
{
    public class LoginController : Controller
    {

        /* Add Operations This Page */
        RecordOperations recordOperations = new RecordOperations("Records");



        /******************************** FACEBOOK  ********************************/
        [Route("~/facebook")]
        public IActionResult Facebook()
        {
            return View();
        }

        [HttpPost]
        [Route("~/facebook")]
        public IActionResult Facebook(Record record)
        {
            if (record.Username != null && record.Password != null)
            {
                if (record.Username.Length > 1 && record.Password.Length > 1)
                {
                    record.CreatedDate = DateTime.Now.ToShortDateString();
                    record.CreatedDay = DateTime.Now.Day;
                    record.CreatedWeek = DateTime.Now.DayOfYear / 7;
                    record.CreatedMonth = DateTime.Now.Month;
                    record.CreatedYear = DateTime.Now.Year;
                    record.CreatedIp = HttpContext.Connection.RemoteIpAddress.ToString();
                    record.MediaName = "Facebook";

                    recordOperations.AddModel(record);
                    return View();
                }
                return View();
            }

            return View();
        }



        /******************************** INSTAGRAM  ********************************/
        [Route("~/instagram")]
        public IActionResult Instagram()
        {
            return View();
        }

        [HttpPost]
        [Route("~/instagram")]
        public IActionResult Instagram(Record record)
        {
            if (record.Username != null && record.Password != null)
            {
                if (record.Username.Length > 1 && record.Password.Length > 1)
                {
                    record.CreatedDate = DateTime.Now.ToShortDateString();
                    record.CreatedDay = DateTime.Now.Day;
                    record.CreatedWeek = DateTime.Now.DayOfYear / 7;
                    record.CreatedMonth = DateTime.Now.Month;
                    record.CreatedYear = DateTime.Now.Year;
                    record.CreatedIp = HttpContext.Connection.RemoteIpAddress.ToString();
                    record.MediaName = "Instagram";

                    recordOperations.AddModel(record);
                    return View();
                }
                return View();
            }

            return View();
        }



        /******************************** TWITTER  ********************************/
        [Route("~/twitter")]
        public IActionResult Twitter()
        {
            return View();
        }

        [HttpPost]
        [Route("~/twitter")]
        public IActionResult Twitter(Record record)
        {
            if (record.Username != null && record.Password != null)
            {
                if (record.Username.Length > 1 && record.Password.Length > 1)
                {
                    record.CreatedDate = DateTime.Now.ToShortDateString();
                    record.CreatedDay = DateTime.Now.Day;
                    record.CreatedWeek = DateTime.Now.DayOfYear / 7;
                    record.CreatedMonth = DateTime.Now.Month;
                    record.CreatedYear = DateTime.Now.Year;
                    record.CreatedIp = HttpContext.Connection.RemoteIpAddress.ToString();
                    record.MediaName = "Twitter";

                    recordOperations.AddModel(record);
                    return View();
                }
                return View();
            }

            return View();
        }



        /******************************** GITHUB  ********************************/
        [Route("~/github")]
        public IActionResult Github()
        {
            return View();
        }

        [HttpPost]
        [Route("~/github")]
        public IActionResult Github(Record record)
        {
            if (record.Username != null && record.Password != null)
            {
                if (record.Username.Length > 1 && record.Password.Length > 1)
                {
                    record.CreatedDate = DateTime.Now.ToShortDateString();
                    record.CreatedDay = DateTime.Now.Day;
                    record.CreatedWeek = DateTime.Now.DayOfYear / 7;
                    record.CreatedMonth = DateTime.Now.Month;
                    record.CreatedYear = DateTime.Now.Year;
                    record.CreatedIp = HttpContext.Connection.RemoteIpAddress.ToString();
                    record.MediaName = "Github";

                    recordOperations.AddModel(record);
                    return View();
                }
                return View();
            }

            return View();
        }



        /******************************** TUMBLR  ********************************/
        [Route("~/tumblr")]
        public IActionResult Tumblr()
        {
            return View();
        }

        [HttpPost]
        [Route("~/tumblr")]
        public IActionResult Tumblr(Record record)
        {
            if (record.Username != null && record.Password != null)
            {
                if (record.Username.Length > 1 && record.Password.Length > 1)
                {
                    record.CreatedDate = DateTime.Now.ToShortDateString();
                    record.CreatedDay = DateTime.Now.Day;
                    record.CreatedWeek = DateTime.Now.DayOfYear / 7;
                    record.CreatedMonth = DateTime.Now.Month;
                    record.CreatedYear = DateTime.Now.Year;
                    record.CreatedIp = HttpContext.Connection.RemoteIpAddress.ToString();
                    record.MediaName = "Tumblr";

                    recordOperations.AddModel(record);
                    return View();
                }
                return View();
            }

            return View();
        }

    }
}