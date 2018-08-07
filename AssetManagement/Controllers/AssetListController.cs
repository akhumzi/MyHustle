using AssetData;
using AssetManagement.Models.AssetList;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Controllers
{
  public class AssetListController : Controller
  {
    private IAssetManagement _assets;

    public AssetListController(IAssetManagement assets)
    {
      _assets = assets;
    }

    public IActionResult Index()
    {
      var assetModels = _assets.GetAllAssets();

      var listingResult = assetModels
        .Select(result => new AssetIndexListingModel
        {
          Id = result.Id,
          SerialNumber = result.SerialNumber,
          AssetName = result.AssetName,
          AssetDescription = result.AssetDescription,
          //PurchasePrice = result.PurchasePrice,
          AssetModel = result.AssetModel 
        });

      var model = new AssetIndexModel()
      {
        Assets = listingResult
      };
      return View(model);
    }
  }
}
