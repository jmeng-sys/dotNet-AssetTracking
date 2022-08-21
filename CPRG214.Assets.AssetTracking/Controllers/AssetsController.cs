using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CPRG214.Assets.BLL;
using Microsoft.AspNetCore.Mvc.Rendering;
using CPRG214.Assets.AssetTracking.Models;

namespace CPRG214.Assets.AssetTracking.Controllers
{
    public class AssetsController : Controller
    {
        public IActionResult Index()
        {
            var assets = AssetManager.GetAll();
            var viewModels = assets.Select( a => new AssetViewModel 
            {
                Id = a.Id,
                Description = a.Description,
                AssetType = a.AssetType.Name,
                TagNumber = a.TagNumber,
                SerialNumber = a.SerialNumber
            }).ToList();
            //call a local service to get the collectiohn of assets as the viewmodle
            return View(viewModels);
        }

        public IActionResult Search()
        {
            ViewBag.AssetTypes = GetAssetTypes();
            return View();
        }

        //public IActionResult Assets(int id)

        protected IEnumerable GetAssetTypes()
        {
            var assetTypes = AssetTypeManager.GetAsKeyValuePairs();
            var types = new SelectList(assetTypes, "Value", "Text");

            var list = types.ToList();
            list.Insert(0, new SelectListItem 
            {
                Value = "0",
                Text = "All Types"    
            });
            return list;
        }

        public IActionResult GetAssetsByType(int id)
        {
            return ViewComponent("AssetsByType", id);
        }
    }
}
