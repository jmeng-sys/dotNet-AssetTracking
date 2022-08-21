using Microsoft.AspNetCore.Mvc;
using CPRG214.Assets.BLL;
using CPRG214.Assets.Domain;

namespace CPRG214.Assets.AssetTracking.Controllers
{
    public class NewTypeController : Controller
    {
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(AssetType assetType)
        {
            try
            {
                AssetTypeManager.Add(assetType);
                return RedirectToAction("Search", "Assets");
            }
            catch
            {
                return View();
            }
        }
    }
}
