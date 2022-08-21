using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CPRG214.Assets.BLL;
using CPRG214.Assets.Domain;
using CPRG214.Assets.AssetTracking.Models;

namespace CPRG214.Assets.AssetTracking.ViewComponents
{
    public class AssetsByTypeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<Asset> assets = null;

            if (id == 0)
            {
                assets = AssetManager.GetAll();
            }
            else
            {
                assets = AssetManager.GetAllByAssetType(id);
            }

            var assetSel = assets.Select(a => new AssetViewModel
            {
                Description = a.Description,
                AssetType = a.AssetType.Name,
                TagNumber = a.TagNumber,
                SerialNumber = a.SerialNumber
            }).ToList();

            return View(assetSel);
        }
    }
}
