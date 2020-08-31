using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Task.Models
{   // Fake DB model
    public class Note
    {
        private static Random _r = new Random();
        private static int id = 0;
        //Fake ID
        public int Id_Note { get; set; }
        //Note  date added
        public DateTime DateAdded { get; set; }
        //Note title
        public string Title { get; set; }
        //Note Message
        public string Message { get; set; }
        //user  who add this
        public virtual User User { get; set; }

        public Note(string title,string mes,User user)
        {
            var year = _r.Next(2000, 2020);
            var month = _r.Next(1, 13);
            var days = _r.Next(1, DateTime.DaysInMonth(year, month) + 1);
            Id_Note = id++;
            DateAdded = new DateTime(year, month, days,_r.Next(0, 24), _r.Next(0, 60), _r.Next(0, 60), _r.Next(0, 1000));
            Title = title;
            Message = mes;
            User = user;
        }

        public override string ToString()
        {
            return $"id={Id_Note}, Title = {Title}, Message = {Message}";
        }
    }
}