﻿using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevHazirlikMaui.Models
{
    internal static class DL
    {
        static FirebaseClient client = new FirebaseClient("https://finalodev-b6bb3-default-rtdb.firebaseio.com/");

        public static bool AddNote(Notes note)
        {
            client.Child($"finalodev/{note.Id}").PutAsync(note);
            return true;
        }

        public static bool EditNote(Notes note)
        {
            client.Child($"finalodev/{note.Id}").PutAsync(note);
            return true;
        }

        public static bool DeleteNote(Notes note)
        {
            client.Child($"finalodev/{note.Id}").DeleteAsync();
            return true;
        }

        public static  ObservableCollection<Notes> GetAllNotes()
        {
            ObservableCollection<Notes> notes = new ObservableCollection<Notes>();
            var _notes =  client.Child("finalodev").OnceAsync<Notes>();

            foreach (var n in _notes.Result)
            {
                notes.Add(n.Object);
            }

            return notes;
        }
    }
}
