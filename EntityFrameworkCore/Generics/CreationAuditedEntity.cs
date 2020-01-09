using System;

namespace Mijalski.EntityFrameworkCore.Generics
{
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>
    {
        public CreationAuditedEntity()
        {
            CreationDateTime = DateTime.UtcNow;
        }

        public DateTime CreationDateTime { get; set; }
    }
}