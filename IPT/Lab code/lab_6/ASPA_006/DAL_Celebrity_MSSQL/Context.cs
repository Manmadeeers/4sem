using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Celebrity_MSSQL
{
    public class Context : DbContext
    {
        public string? ConnectionString { get; private set; } = null;
        public Context(string connextionString) : base()
        {
            ConnectionString = connextionString;
        }

        public Context() : base()
        {

        }

        public DbSet<Celebrity> Celebrities { get; set; }

        public DbSet<LifeEvent> LifeEvents { get; set; }

    }
}
