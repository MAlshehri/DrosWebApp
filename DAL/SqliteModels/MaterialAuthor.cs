using System;

namespace DAL.SqliteModels
{
    public class MaterialAuthor
    {
        public Guid MaterialId { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public Material Material { get; set; }
    }
}