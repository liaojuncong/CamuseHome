using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Models
{
    public class PopuplstElement
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EN { get; set; }
        public bool Disable { get; set; }
        public long PopuplstId { get; set; }
        public virtual Popuplst Popuplst { get; set; }
    }
}
