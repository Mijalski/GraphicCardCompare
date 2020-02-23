using System;
using System.Collections.Generic;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Generics;

namespace DomainLogic.Business.Vendors
{
    public class Vendor : CreationAuditedEntity
    {
        public Vendor()
        {
            Id = Guid.NewGuid();
            GraphicCards = new HashSet<GraphicCard>();
        }

        public virtual HashSet<GraphicCard> GraphicCards { get; set; }
    }
}