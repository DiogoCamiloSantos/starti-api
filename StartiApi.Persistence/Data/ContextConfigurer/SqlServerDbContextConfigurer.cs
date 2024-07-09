using Microsoft.EntityFrameworkCore;
using Starti.Persistence.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starti.Persistence.Data.ContextConfigurer
{
    internal class SqlServerDbContextConfigurer : IDbContextConfigurer
    {
        public void Configure(DbContextOptionsBuilder optionsBuilder, string connectionString)
        {
            //optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
