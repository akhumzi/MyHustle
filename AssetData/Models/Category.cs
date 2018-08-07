using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AssetData.Models
{
  public class Category
  {
    public int Id { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Limit to 50 Characters")]
    public string CategoryDescription { get; set; }
  }
}
