using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long ParentId { get; set; }
    }
}
