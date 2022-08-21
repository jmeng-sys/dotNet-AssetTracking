using System.Collections;
using CPRG214.Assets.Data;
using System.Linq;
using CPRG214.Assets.Domain;

namespace CPRG214.Assets.BLL
{
    public class AssetTypeManager
    {
        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetContext();
            var types = context.AssetTypes.Select(t => new
            {
                Value = t.Id,
                Text = t.Name
            }).ToList();
            return types;
        }

        public static void Add(AssetType assetType)
        {
            var context = new AssetContext();
            context.AssetTypes.Add(assetType);
            context.SaveChanges();
        }
    }
}
