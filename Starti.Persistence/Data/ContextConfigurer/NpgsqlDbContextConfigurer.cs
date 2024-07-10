using Microsoft.EntityFrameworkCore;
using Starti.Persistence.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starti.Persistence.Data.ContextConfigurer
{
    internal class NpgsqlDbContextConfigurer : IDbContextConfigurer
    {
        public void Configure(DbContextOptionsBuilder optionsBuilder, string connectionString)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
    }

}
