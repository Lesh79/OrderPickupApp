using System.ComponentModel.DataAnnotations;

namespace OrderPickupApp.Models;

public class Order
{
    public int Id { get; set; }
    [Required]
    public string SenderCity { get; set; }
    [Required]
    public string SenderAddress { get; set; }
    [Required]
    public string ReceiverCity { get; set; }
    [Required]
    public string ReceiverAddress { get; set; }
    [Required]
    public double CargoWeight { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime PickupDate { get; set; }
}