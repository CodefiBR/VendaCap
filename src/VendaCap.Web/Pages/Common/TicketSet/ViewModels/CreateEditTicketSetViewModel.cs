using System;
using System.ComponentModel.DataAnnotations;

namespace VendaCap.Web.Pages.Common.TicketSet.ViewModels;

public class CreateEditTicketSetViewModel
{
    [Display(Name = "TicketSetDrawDate")]
    public DateTime DrawDate { get; set; }

    [Display(Name = "TicketSetAmount")]
    public int Amount { get; set; }

    [Display(Name = "TicketSetPrice")]
    public int Price { get; set; }
}
