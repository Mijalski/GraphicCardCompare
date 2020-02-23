using System;
using ApplicationLogic.IGenerics;

namespace ApplicationLogic.Business.Vendors
{
    public class VendorDto : IEntityDto
    {
        public string Name { get; set; }
    }
}