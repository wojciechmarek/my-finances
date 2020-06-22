using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyFinances.Database.Models
{
    public class FavorityAsset
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AssetId { get; set; }
    }
}
