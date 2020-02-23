using System;

namespace DomainLogic.Generics
{
    public abstract class CreationAuditedEntity : Entity
    {
        public CreationAuditedEntity()
        {
            CreationDateTime = DateTime.UtcNow;
        }

        public DateTime CreationDateTime { get; set; }
    }
}