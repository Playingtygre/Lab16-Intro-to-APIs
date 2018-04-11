using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{

    //creates to-do Class : adding Interface of DB context
    public class TodoContext : DbContext
    {
              //name of class   list of DB items <collections>
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
