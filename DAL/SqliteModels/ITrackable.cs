using System;

namespace DAL.SqliteModels
{
    public interface ITrackable
    {
        DateTimeOffset CreatedOn { get; set; }
        DateTimeOffset UpdatedOn { get; set; }
    }
}