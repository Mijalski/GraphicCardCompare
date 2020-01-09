using System;
using Mijalski.EntityFrameworkCore.Business.Specs;
using Mijalski.EntityFrameworkCore.Business.Vendors;
using Mijalski.EntityFrameworkCore.Generics;

namespace Mijalski.EntityFrameworkCore.Business.GraphicCards
{
    public class GraphicCard : CreationAuditedEntity<Guid>
    {
        public GraphicCard()
        {
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Price { get; set; }
        public Ram Ram { get; set; }
        public string InterfaceType { get; set; }
        public string ProcessorSpeed { get; set; }
        public string Wattage { get; set; }
        public Guid VendorId { get; set; }
        public virtual Vendor Vendor { get; set; } 
    }
}