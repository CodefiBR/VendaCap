using System;

namespace VendaCap.Common.Dtos;

[Serializable]
public class CreateUpdateTicketSetDto
{
    public DateTime DrawDate { get; set; }

    public int Amount { get; set; }

    public Decimal Price { get; set; }
}