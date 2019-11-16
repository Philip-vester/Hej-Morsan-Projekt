﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Dapper;

namespace Hej_Morsan_Projekt.Pages
{
    public class IndexModel : PageModel
    {
        // creates list to store persons from database 
        public List<Person> myPersons { get; set; }
        
        public void OnGet()
        {
            // creates connection object to connect to database
            var db = new DB("Server=40.85.84.155;Database=Student13;User=Student13;Password=YH-student@2019;");

            List<Person> myPersons = new List<Person>();

            // adds persons from databas to list
            foreach (var item in db.GetPersons())
            {
                myPersons.Add(item);
            }
        }
    }
}
