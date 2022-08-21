using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPRG214.Assets.Domain
{
    [Table("AssetType")]
    public class AssetType
    {
        public int Id { get; set; }
        [Required] 
        [Display (Name = "Asset Type")]
        public string Name { get; set; }
        // navagation property (one-to-many)
        public ICollection<Asset> Assets { get; set; }
    }
}
