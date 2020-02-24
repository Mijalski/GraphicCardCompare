using System;
using ApplicationLogic.IGenerics;

namespace ApplicationLogic.Business.Vendors
{
    public class VendorDto : IEntityDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}