using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPRG214.Assets.AssetTracking.Models
{
    public class AssetViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [Display(Name = "Asset Type")]
        public string AssetType { get; set; }
        [Display(Name ="Tag Number")]
        public string TagNumber { get; set; } 
        [Display(Name ="Serial Number")]
        public string SerialNumber { get; set; }
        
    }
}
