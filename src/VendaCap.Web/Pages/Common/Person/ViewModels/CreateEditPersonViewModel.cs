using System;
using System.ComponentModel.DataAnnotations;

namespace VendaCap.Web.Pages.Common.Person.ViewModels;

public class CreateEditPersonViewModel
{
    [Display(Name = "PersonName")]
    public String Name { get; set; }

    [Display(Name = "PersonDocument")]
    public String Document { get; set; }

    [Display(Name = "PersonBirthDate")]
    public DateTime BirthDate { get; set; }

    [Display(Name = "PersonCellPhone")]
    public String CellPhone { get; set; }

    [Display(Name = "PersonPhone")]
    public String Phone { get; set; }

    [Display(Name = "PersonEmail")]
    public String Email { get; set; }

    [Display(Name = "PersonZipCode")]
    public String ZipCode { get; set; }

    [Display(Name = "PersonAddress")]
    public String Address { get; set; }

    [Display(Name = "PersonAddressNumber")]
    public String AddressNumber { get; set; }

    [Display(Name = "PersonAddressComplement")]
    public String AddressComplement { get; set; }

    [Display(Name = "PersonNeighborhood")]
    public String Neighborhood { get; set; }

    [Display(Name = "PersonCityName")]
    public String CityName { get; set; }

    [Display(Name = "PersonStateName")]
    public String StateName { get; set; }
}
