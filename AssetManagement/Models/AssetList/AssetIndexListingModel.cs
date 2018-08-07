using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Models.AssetList
{
    public class AssetIndexListingModel
    {
    public int Id { get; set; }
    public string SerialNumber { get; set; }
    public string AssetName { get; set; }
    public string AssetDescription { get; set; }
    public decimal PurchasePrice { get; set; }
    public string AssetModel { get; set; }
    //public virtual Condition Condition { get; set; }
    //public virtual Category Category { get; set; }
  }
}
