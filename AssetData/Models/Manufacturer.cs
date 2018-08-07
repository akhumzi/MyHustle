using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AssetData.Models
{
  public class Manufacturer
    {
    public int Id { get; set; }
    [Required] 
    public string ManufactureName { get; set; }
    public string ManufactureContactPerson { get; set; }
    [Required] 
    public string ManufactureContactNumber { get; set; }
    }
}
