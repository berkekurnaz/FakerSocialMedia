using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakerSocialMedia.DataAccessLayer.Concrete;
using FakerSocialMedia.Filter.Auth;
using FakerSocialMedia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FakerSocialMedia.Controllers
{
    [AuthFilter]
    public class PanelUserController : Controller
    {
        /* Add Operations This Page */
        UserOperations userOperations = new UserOperations("Users");

        public IActionResult GetAll()
        {
            var items = userOperations.GetAll().OrderByDescending(x => x.Id);
            return View(items);
        }

        public IActionResult GetById(int Id)
        {
            var item = userOperations.GetById(Id);
            if (item == null)
            {
                return RedirectToAction("Error", "Panel");
            }
            return View(item);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User model)
        {
            userOperations.AddModel(model);
            return RedirectToAction("GetAll");
        }

        public IActionResult Update(int Id)
        {
            var item = userOperations.GetById(Id);
            if (item == null)
            {
                return RedirectToAction("Error", "Panel");
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Update(int Id, User newModel)
        {
            var model = userOperations.GetById(Id);

            model.Username = newModel.Username;
            model.Password = newModel.Password;
            model.IsAdmin = newModel.IsAdmin;
            model.ApiKey = newModel.ApiKey;

            userOperations.UpdateModel(model);

            return RedirectToAction("GetAll");
        }

        public IActionResult Delete(int Id)
        {
            var item = userOperations.GetById(Id);
            if (item == null)
            {
                return RedirectToAction("Error", "Panel");
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(int Id, IFormCollection collection)
        {
            userOperations.DeleteModel(Id);
            return RedirectToAction("GetAll");
        }

    }
}