using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Models
{
    public class Popuplst
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PopuplstElement> Elements { get; set; }
    }
}
