using ASP_intro.Models;
using ASP_intro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_intro.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            Group group1 = new Group()
            {
                Id= 1,
                Name="p515"
               
            };
            Group group2 = new Group()
            {
                Id = 2,
                Name = "p500"
            };
            Group group3 = new Group()
            {
                Id = 3,
                Name = "p555"
            };
            List<Group> groups = new List<Group>();
            groups.Add(group1);
            groups.Add(group2);
            groups.Add(group3);
            

            return View(groups);
        }
        public  IActionResult Detail(int id)
        {
            Group group4 = new Group()
            {
                Id = 1,
                Name = "p515"

            };
            Group group5 = new Group()
            {
                Id = 2,
                Name = "p500"
            };
            Group group6 = new Group()
            {
                Id = 3,
                Name = "p555"
            };
            List<Group> Allgroups = new List<Group>();
            Allgroups.Add(group4);
            Allgroups.Add(group5);
            Allgroups.Add(group6);
            HomeVM homeVM = new HomeVM
            {
                Groups = Allgroups
            };
            
            return View(homeVM.Groups.Find(g => g.Id == id));
        }
    }
}
