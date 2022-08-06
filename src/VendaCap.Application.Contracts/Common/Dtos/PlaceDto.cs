using System;
using Volo.Abp.Application.Dtos;

namespace VendaCap.Common.Dtos;

[Serializable]
public class PlaceDto : EntityDto<int>
{
    public String Name { get; set; }

    public String Abbrev { get; set; }

    public String IbgeCode { get; set; }

    public String BacenCode { get; set; }
}