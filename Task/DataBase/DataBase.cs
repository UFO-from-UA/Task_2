using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task.Models;

namespace Task.Views.DataBase
{
    // Instead of a database
    public class DataBase
    {
        //Fake data list of notes 
        //Not private  becouse we work with copy  of data from Database (Autonomous level)
        public static List<Note> noteList;

        static DataBase()
        {
            
                noteList = new List<Note>();
                InitDataBase();
        }

        private static void InitDataBase()
        {
            FillFakeDataBase();
        }

        private static void FillFakeDataBase()
        {
            noteList.Add(
             new Note("Unreal tite", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Culpa excepturi, expedita eum molestiae error explicabo libero in",
                new User("Awesome NickName", "Email@@@")
                )
            );

            noteList.Add(
          new Note("Some tite", " consectetur adipisicing elit. Culpa excepturi, Lorem ipsum dolor sit amet,libero in  expedita eum molestiae error explicabo ",
             new User("Ivanov Valera", "someEmail@some_domen.yep")
             )
         );

            noteList.Add(
          new Note("Song", @"We Are Number One but it is Dark Cabaret Metal.
                                    This cover is the part of Tardigrade Inferno new album 'Mastermind'!
                                    https://www.youtube.com/watch?v=mzJ4vCjSt28&feature=youtu.be",
             new User("Number One", "EmailAgain@but.it.is.not_exactly")
             )
         );

            noteList.Add(
          new Note("The power of the classics", @"Иоганн Себастьян Бах. Токката и фуга ре минор.
                                https://www.youtube.com/watch?v=qPNtI2wM9Yo&list=RDqPNtI2wM9Yo&start_radio=1",
             new User("UFO", "Email@bah.mix")
             )
         );

        }
    }
}