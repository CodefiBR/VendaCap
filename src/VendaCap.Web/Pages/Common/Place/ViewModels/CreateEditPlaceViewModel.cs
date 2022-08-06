using System;
using System.ComponentModel.DataAnnotations;

namespace VendaCap.Web.Pages.Common.Place.ViewModels;

public class CreateEditPlaceViewModel
{
    [Display(Name = "PlaceName")]
    public String Name { get; set; }

    [Display(Name = "PlaceAbbrev")]
    public String Abbrev { get; set; }

    [Display(Name = "PlaceIbgeCode")]
    public String IbgeCode { get; set; }

    [Display(Name = "PlaceBacenCode")]
    public String BacenCode { get; set; }
}
