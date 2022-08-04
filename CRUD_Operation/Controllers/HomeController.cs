using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_Operation.Context;

namespace CRUD_Operation.Controllers
{
    public class HomeController : Controller
    {
        //Index Page or Home Page
        public ActionResult Index()
        {
            return View();
        }

        //Insertion Operation
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                CRUDOperationEntities obj = new CRUDOperationEntities();
                obj.Students.Add(student);
                obj.SaveChanges();
                ModelState.Clear();
                student = null;
                ViewBag.Message = "Data Inserted Successfully!";
            }
            return View(student);
        }

        //Display All Operation
        public ActionResult Read()
        {
            CRUDOperationEntities obj = new CRUDOperationEntities();
            var data = obj.Students.ToList();
            return View(data);
        }

        //Update Operation
        public ActionResult Update(int id)
        {
            CRUDOperationEntities obj = new CRUDOperationEntities();
            var result = (from item in obj.Students where item.StudentId == id select item).First();
            return View("Update", result);
        }
        [HttpPost]
        public ActionResult Update(Student stu)
        {
            CRUDOperationEntities obj = new CRUDOperationEntities();
            var result = (from item in obj.Students where item.StudentId == stu.StudentId select item).First();

            result.FirstName = stu.FirstName;
            result.LastName = stu.LastName;
            result.PhoneNo = stu.PhoneNo;
            result.Email = stu.Email;

            obj.SaveChanges();

            var records = obj.Students.ToList();
            return View("Read", records);
        }

        //Delete Operation
        public ActionResult Delete(string firstname)
        {
            CRUDOperationEntities obj = new CRUDOperationEntities();
            var res = obj.Students.Where(student => student.FirstName == firstname).First();
            obj.Students.Remove(res);
            obj.SaveChanges();
            var data = obj.Students.ToList();
            return View("Read", data);
        }
    }
}