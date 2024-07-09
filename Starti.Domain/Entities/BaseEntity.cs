using Starti.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starti.Domain.Extensions;

namespace Starti.Domain.Entities
{
    public abstract class BaseEntity : BaseRegisterEntity
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
