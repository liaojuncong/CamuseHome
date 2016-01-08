
using System.ComponentModel.DataAnnotations.Schema;

namespace CamuseHome
{
    [Table("Category")]
    public class modCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long ParentId { get; set; }
    }
}
