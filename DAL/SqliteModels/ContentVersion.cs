using System;

namespace DAL.SqliteModels
{
    public class ContentVersion
    {
        public DateTimeOffset UpdatedOn { get; set; }
        public Guid Veriosn { get; set; }
    }
}