using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AssetData.Models
{
  public class Asset
  {
    public int Id { get; set; }
    public string SerialNumber { get; set; }
    public string AssetName { get; set; }
    public string AssetDescription { get; set; }
    //public decimal PurchasePrice { get; set; }
    public string AssetModel { get; set; }
    public string AssetComment { get; set; }
    public DateTime AcquiredDate { get; set; }
    public DateTime WarrantyDate { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime RetiredDate { get; set; }
    public bool isDeleted { get; set; }

    //[Required]
    //public virtual IEnumerable<AssetStatus> AssetStatuses { get; set; } 

    //public virtual IEnumerable<Attachments> Attachments { get; set; }
    //public virtual Condition Condition { get; set; }
    //public virtual Category Category { get; set; }
    //public virtual Manufacturer Manufacturer { get; set; }
    //public virtual Repair Repair { get; set; }
  }
}
