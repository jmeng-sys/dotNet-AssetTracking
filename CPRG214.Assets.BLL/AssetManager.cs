using System.Collections;
using CPRG214.Assets.Data;
using System.Linq;
using System.Collections.Generic;
using CPRG214.Assets.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CPRG214.Assets.BLL
{
    public class AssetManager
    {
        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetContext();
            var assets = context.Assets.Select(a => new
            {
                Value = a.Id,
                Text = a.TagNumber
            }).ToList();
            return assets;
        }

        public static List<Asset> GetAll()
        {
            var context = new AssetContext();
            var assets = context.Assets.Include(a => a.AssetType).ToList();
            return assets;
        }

        public static List<Asset> GetAllByAssetType(int id)
        {
            var context = new AssetContext();
            var assets = context.Assets.
                Where(asset => asset.AssetTypeId == id).
                Include(a => a.AssetType).ToList();
                
            return assets;
        }

        public static void Add(Asset asset)
        {
            var context = new AssetContext();
            context.Assets.Add(asset);
            context.SaveChanges();
        }
    }
}
