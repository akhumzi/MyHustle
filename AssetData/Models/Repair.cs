using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AssetData.Models
{
    public class Repair
    {
    public int Id { get; set; }
    [Required] 
    public string Fault { get; set; }
    public string Satisfaction { get; set; }
    public DateTime DateBookedIn { get; set; }
    public DateTime DateCollected { get; set; } 

  }
}
