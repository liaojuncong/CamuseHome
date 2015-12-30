
namespace CamuseHome
{
    public class modPicture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Remark { get; set; }
        public int ProductId { get; set; }
        public virtual modProduct Product { get; set; }
    }
}
