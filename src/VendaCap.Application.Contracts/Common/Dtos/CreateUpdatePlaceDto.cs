using System;

namespace VendaCap.Common.Dtos;

[Serializable]
public class CreateUpdatePlaceDto
{
    public String Name { get; set; }

    public String Abbrev { get; set; }

    public String IbgeCode { get; set; }

    public String BacenCode { get; set; }
    
}