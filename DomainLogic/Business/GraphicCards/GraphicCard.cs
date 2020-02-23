using System;
using DomainLogic.Business.Specs;
using DomainLogic.Business.Vendors;
using DomainLogic.Generics;

namespace DomainLogic.Business.GraphicCards
{
    public class GraphicCard : CreationAuditedEntity
    {
        public GraphicCard()
        {
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public Ram Ram { get; set; }
        public string InterfaceType { get; set; }
        public string ProcessorSpeed { get; set; }
        public double Wattage { get; set; }
        public Guid VendorId { get; set; }
        public virtual Vendor Vendor { get; set; } 
    }
}