using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace VendaCap.Common
{
    public class Person : AuditedAggregateRoot<Guid>
    {
        public String Name { get; set; }
        public String Document { get; set; }
        public DateTime BirthDate { get; set; }
        public String CellPhone { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String ZipCode { get; set; }
        public String Address { get; set; }
        public String AddressNumber { get; set; }
        public String AddressComplement { get; set; }
        public String Neighborhood { get; set; }
        public String CityName { get; set; }
        public String StateName { get; set; }
        public Place Place { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
