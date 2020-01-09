using System;

namespace Mijalski.EntityFrameworkCore.Generics
{
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>
    {
        public DateTime CreationDateTime { get; set; }
    }
}