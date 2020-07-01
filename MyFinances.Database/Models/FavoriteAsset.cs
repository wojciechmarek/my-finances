using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFinances.Database.Models
{
    public class FavoriteAsset
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string AssetId { get; set; }
    }
}
