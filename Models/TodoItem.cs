using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; } //functions as the unique key in a relational database
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string secret { get; set; }
    }// The database context is the main class that coordinates Entity Framework Functionality for a data model
}    //database context class - derived from Microsoft.EntityFrameworkCore.DbContext
