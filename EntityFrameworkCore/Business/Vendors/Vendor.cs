using System;
using System.Collections.Generic;
using Mijalski.EntityFrameworkCore.Business.GraphicCards;
using Mijalski.EntityFrameworkCore.Generics;

namespace Mijalski.EntityFrameworkCore.Business.Vendors
{
    public class Vendor : CreationAuditedEntity<Guid>
    {
        public Vendor()
        {
            Id = Guid.NewGuid();
            GraphicCards = new HashSet<GraphicCard>();
        }

        public string Name { get; set; }
        public virtual HashSet<GraphicCard> GraphicCards { get; set; }
    }
}