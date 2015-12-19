using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Models
{
    public class Cost
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public decimal Money { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
