using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AssetData.Models
{
  public class OwnershipHistory
  {
    public int Id { get; set; }
    [Required]
    public string Reason { get; set; }
    public DateTime OwnershipHistoryCreatedOnDate { get; set; }

    public virtual IEnumerable<Employee> Employees { get; set; }
    public virtual IEnumerable<Asset> Assets { get; set; }
  }
}
