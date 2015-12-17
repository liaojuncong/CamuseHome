using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Models
{
    public class Picture
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Remark { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
