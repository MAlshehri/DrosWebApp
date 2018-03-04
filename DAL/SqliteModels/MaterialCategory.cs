using System;

namespace DAL.SqliteModels
{
    public class MaterialCategory
    {
        public Guid MaterialId { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Material Material { get; set; }
    }
}