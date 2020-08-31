using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task.Models;

namespace Task.Views.ViewModels
{
    public class ViewModel
    {
        public int Id_Note { get; set; }
        public string Title { get; set; }
        public string DateAdded { get; set; }
        public string Message { get; set; }
        public User User{ get; set; }
    }
}