using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CPRG214.Assets.BLL;
using Microsoft.AspNetCore.Mvc.Rendering;
using CPRG214.Assets.Domain;

namespace CPRG214.Assets.AssetTracking.Controllers
{
    public class NewAssetController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Create()
        {
            // call the AssetTypeManager to get the collection of key value objects
            var assetTypes = AssetTypeManager.GetAsKeyValuePairs();
            //create a collection of SelectListItems (get list from AssetType table). 
            //"Value" & "Text" should match those assigned in AssetTypeManager 
            var list = new SelectList(assetTypes, "Value", "Text");
            //assign the list to ViewBag (strongly typed placeholder)
            ViewBag.AssetTypeId = list;

            return View();

        }

        [HttpPost]
        public IActionResult Create(Asset asset)
        {
            try
            {
                AssetManager.Add(asset);
                return RedirectToAction("Search", "Assets");
            }
            catch
            {
                return View();
            }
        }
    }
}
