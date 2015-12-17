using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamuseHome.Models
{
    public class Product
    {
        public Product()
        {
            Pictures = new List<Picture>();
        }
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public string Specification { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public string Packing { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
