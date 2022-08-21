using System;
using System.ComponentModel.DataAnnotations;
using CPRG214.Assets.Domain;

namespace CPRG214.Assets.AssetTracking.Models
{
    public class NewTypeViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Asset Type")]
        public string Name { get; set; }
    }
}
