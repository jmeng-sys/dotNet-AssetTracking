using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CPRG214.Assets.Domain;

namespace CPRG214.Assets.AssetTracking.Models
{
    public class NewAssetViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tag Number")]
        public string TagNumber { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }
        [Required]
        [Display(Name = "Asset Type")]
        public int AssetTypeId { get; set; }
        [Required]        
        public AssetType AssetType { get; set; }

    }
}