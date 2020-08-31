using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Models;
using Task.Views.DataBase;
using Task.Views.ViewModels;

namespace Task.Controllers
{
    public class NotesController : Controller
    {
        private List<Note> _db = DataBase.noteList;
        // GET: Notes
        public ActionResult Index()
        {
            ViewBag.Header = Localization.LocalizationResource.list;
            return View("notes",_db);
        }

        // GET: Notes/Details/id
        public ActionResult Details(int id)
        {
            return View(_db.Where(it => it.Id_Note==id).First());
        }

        // GET: Notes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var ss = collection.GetValue("User.UserName").RawValue;
                DataBase.noteList.Add(new Note(
                collection.GetValue("Title").AttemptedValue,
                collection.GetValue("Message").AttemptedValue,
                new User(
                collection.GetValue("User.UserName").AttemptedValue,
                collection.GetValue("User.Email").AttemptedValue)
                    ));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Notes/Edit/id
        public ActionResult Edit(int id)
        {
            return View(_db.Where(it => it.Id_Note == id).First());
        }

        // GET: Notes/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_db.Where(it => it.Id_Note == id).First());
        }

        // POST: Notes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                DataBase.noteList.RemoveAt(DataBase.noteList.FindIndex(x => x.Id_Note == id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Notes/Edit/id
        [HttpPost]
        public ActionResult SubmitData( ViewModel vm)
        {
            SaveChanges( vm);
            //Response.Redirect("http://");
            return RedirectToAction("Index");
        }

        private void SaveChanges( ViewModel vm)
        {
            var temp = DataBase.noteList.Where(x => x.Id_Note == vm.Id_Note).First();
            temp.Title = vm.Title;
            temp.Message = vm.Message;
            temp.User = vm.User;
            try
            {
                temp.DateAdded = DateTime.Parse(vm.DateAdded);
            }
            catch (Exception)
            {

            }
        }
    }
}
