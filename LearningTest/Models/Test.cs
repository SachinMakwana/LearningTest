using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningTest.Models
{
    public class Test
    {
        public int Id { get; set; }

        public string name { get; set; }
    }

    public class Menu
    {
        public int ID { get; set; }

        public string Name{get;set;}

        public string ActionName { get; set; }
        public string ControllerName { get; set; }

        public List<SubMenu> subMenus { get; set; }

        public Menu()
        {
            subMenus = new List<SubMenu>();
        }
    }

    public class SubMenu
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ActionName { get; set; }
        public string ControllerName { get; set; }

      
    }

    public class Info
    {
        public int country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}