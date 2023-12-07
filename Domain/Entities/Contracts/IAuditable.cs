using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Contracts
{
    internal interface IAuditable<T>
    {
        public DateTime CreatedOn { get; set; }
        public T CreatedBy { get; set; }

        public DateTime UpdateOn { get; set; }  
        public T UpdateBy { get; set; }
    }
}
