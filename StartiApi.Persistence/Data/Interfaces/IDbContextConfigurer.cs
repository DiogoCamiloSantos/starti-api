using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starti.Persistence.Data.Interfaces
{
    public interface IDbContextConfigurer
    {
        void Configure(DbContextOptionsBuilder optionsBuilder, string connectionString);
    }
}
