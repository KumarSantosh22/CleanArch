using Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Auditable: IAuditable<int>
    {
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }

        public DateTime UpdateOn { get; set; }
        public int UpdateBy { get; set; }
    }
}
