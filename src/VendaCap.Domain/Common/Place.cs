using System;
using Volo.Abp.Domain.Entities;

namespace VendaCap.Common
{
    public class Place : Entity<int>
    {
        public String Name { get; set; }
        public String Abbrev { get; set; }
        public String IbgeCode { get; set; }
        public String BacenCode { get; set; }
        public Place PlaceParent { get; set; }

    protected Place()
    {
    }

    public Place(
        int id,
        String name,
        String abbrev,
        String ibgeCode,
        String bacenCode,
        Place placeParent
    ) : base(id)
    {
        Name = name;
        Abbrev = abbrev;
        IbgeCode = ibgeCode;
        BacenCode = bacenCode;
        PlaceParent = placeParent;
    }
    }
}
