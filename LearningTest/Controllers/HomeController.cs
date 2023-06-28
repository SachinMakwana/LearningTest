using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningTest.Models;

namespace LearningTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Test test = new Test();
            //test.Id = 1;
            //test.name = "Test Home";

            //List menu
            List<Menu> menus = new List<Menu>();
            List<SubMenu> subMenus = new List<SubMenu>();

            //single menu object
            Menu menu = new Menu();
            menu.ID = 1;
            menu.Name = "About";
            menu.ControllerName = "Home";
            menu.ActionName = "Contact";

            SubMenu subMenu = new SubMenu();
            subMenu.ID = 1;
            subMenu.Name = "AboutChild";
            subMenu.ControllerName = "Home";
            subMenu.ActionName = "Contact";
            //single menu --> submenus
            //menu.subMenus.Add(subMenu);
            subMenus.Add(subMenu);

            SubMenu subMenu1 = new SubMenu();
            subMenu1.ID = 2;
            subMenu1.Name = "AboutChild2";
            subMenu1.ControllerName = "Home";
            subMenu1.ActionName = "Contact";
            //single menu --> submenus
            //menu.subMenus.Add(subMenu1);
            subMenus.Add(subMenu1);

            menu.subMenus = subMenus;

            menus.Add(menu);

            subMenus = new List<SubMenu>();
            menu = new Menu();
            menu.ID = 2;
            menu.Name = "Second";
            menu.ControllerName = "Home";
            menu.ActionName = "Contact";

            subMenu = new SubMenu();
            subMenu.ID = 1;
            subMenu.Name = "SecondAboutChild";
            subMenu.ControllerName = "Home";
            subMenu.ActionName = "Contact";
            //single menu --> submenus
            //menu.subMenus.Add(subMenu);
            subMenus.Add(subMenu);

            subMenu1 = new SubMenu();
            subMenu1.ID = 2;
            subMenu1.Name = "SecondAboutChild2";
            subMenu1.ControllerName = "Home";
            subMenu1.ActionName = "Contact";
            //single menu --> submenus
            //menu.subMenus.Add(subMenu1);
            subMenus.Add(subMenu1);

            menu.subMenus = subMenus;

            menus.Add(menu);

            return View(menus);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //[HttpPost]
        ////public ActionResult Contact(FormCollection frm)
        //public ActionResult Contact(Info info)
        //{
        //    //Info menu = new Info();
        //    //menu.country = Convert.ToInt32(frm["country"]);
        //    //menu.FirstName = frm["FirstName"];
        //    //menu.LastName = frm["LastName"];
        //    return View();
        //}

        [HttpPost]
        //public ActionResult Contact(FormCollection frm)
        public ActionResult Contact(Info info,FormCollection frm)
        {
            //Info menu = new Info();
            //menu.country = Convert.ToInt32(frm["country"]);
            //menu.FirstName = frm["FirstName"];
            //menu.LastName = frm["LastName"];
            return View();
        }
    }
}