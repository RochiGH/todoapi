using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class DoneContext : DbContext
    {
        public DoneContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<DoneItem> DoneItems { get; set; }
    }
}
