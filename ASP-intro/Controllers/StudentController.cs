using ASP_intro.Models;
using ASP_intro.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;

namespace ASP_intro.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student stu1 = new Student();
            stu1.Id = 1;
            stu1.Name = "Lorem";
            stu1.GroupID = 1;
            

            Student stu2 = new Student();
            stu2.Id = 2;
            stu2.Name = "Lorem1";
            stu2.GroupID = 1;


            Student stu3 = new Student();
            stu3.Id = 3;
            stu3.Name = "Ipsum";
            stu3.GroupID = 2;


            Student stu4 = new Student();
            stu4.Id = 4;
            stu4.Name = "Ipsum1";
            stu4.GroupID = 2;



            Student stu5 = new Student();
            stu5.Id = 5;
            stu5.Name = "Doler";
            stu5.GroupID = 3;


            Student stu6 = new Student();
            stu6.Id = 6;
            stu6.Name = "Doler1";
            stu6.GroupID = 3;
            


            List<Student> students = new List<Student>();
            students.Add(stu1);
            students.Add(stu2);
            students.Add(stu3);
            students.Add(stu4);
            students.Add(stu5);
            students.Add(stu6);

            HomeVM homeVM = new HomeVM
            {
                
                Students = students
         
            };


            return View(homeVM);
        }

        public IActionResult Detail(int id)
        {

            Student stu1 = new Student();
            stu1.Id = 1;
            stu1.Name = "Lorem";





            Student stu2 = new Student();
            stu2.Id = 2;
            stu2.Name = "Lorem1";




            Student stu3 = new Student();
            stu3.Id = 3;
            stu3.Name = "Ipsum";
            


            Student stu4 = new Student();
            stu4.Id = 4;
            stu4.Name = "Ipsum1";
           



            Student stu5 = new Student();
            stu5.Id = 5;
            stu5.Name = "Doler";


            Student stu6 = new Student();
            stu6.Id = 6;
            stu6.Name = "Doler1";



            List<Student> students = new List<Student>();
            students.Add(stu1);
            students.Add(stu2);
            students.Add(stu3);
            students.Add(stu4);
            students.Add(stu5);
            students.Add(stu6);

            HomeVM homeVM = new HomeVM
            {

                Students = students

            };

            return View(homeVM.Students.Find(s => s.Id == id));
        }
        public IActionResult GetStudentWithGroupId(Group groupId)
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



            Student stu1 = new Student();
            stu1.Id = 1;
            stu1.Name = "Lorem";
            stu1.GroupID = 1;





            Student stu2 = new Student();
            stu2.Id = 2;
            stu2.Name = "Lorem1";
            stu2.GroupID= 1;




            Student stu3 = new Student();
            stu3.Id = 3;
            stu3.Name = "Ipsum";
            stu3.GroupID = 2;


            Student stu4 = new Student();
            stu4.Id = 4;
            stu4.Name = "Ipsum1";
            stu4.GroupID = 2;



            Student stu5 = new Student();
            stu5.Id = 5;
            stu5.Name = "Doler";
            stu5.GroupID = 3;


            Student stu6 = new Student();
            stu6.Id = 6;
            stu6.Name = "Doler1";
            stu6.GroupID = 3;



            List<Student> students = new List<Student>();
            students.Add(stu1);
            students.Add(stu2);
            students.Add(stu3);
            students.Add(stu4);
            students.Add(stu5);
            students.Add(stu6);

            HomeVM homeVM = new HomeVM
            {
                Groups=Allgroups,
                Students = students
            };

            
           return View(homeVM);
               
        }
    }
}
