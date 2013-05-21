using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockoutTodoExample.Models;
using WeenyMapper;

namespace KnockoutTodoExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly Repository _repository = new Repository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateItems()
        {
            var itemCount = _repository.Count<TodoItem>().Execute();
            var isDatabaseEmpty = itemCount <= 0;

            if (isDatabaseEmpty)
            {
                _repository.Insert(new[]
                {
                    new TodoItem("Städa"),
                    new TodoItem("Handla"),
                    new TodoItem("Koda"),
                });    
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeleteItems()
        {
            _repository.Delete<TodoItem>().Execute();

            return RedirectToAction("Index");
        }
    }
}
