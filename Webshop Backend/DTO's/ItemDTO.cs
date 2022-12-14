using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Webshop_Backend.Models;

namespace Webshop_Backend.DTO_s
{

        [Table(name: "Items")]
        public class ItemDTO
   {

            [Key]
            public int ItemID { get; set; }

            [Column(TypeName = "varchar(500)")]
            public string ItemName { get; set; } = string.Empty;

            [Column(TypeName = "varchar(500)")]
            public string ItemInfo { get; set; } = string.Empty;

            [Column(TypeName = "varchar(500)")]
            public string ItemImage { get; set; } = string.Empty;

            [Column(TypeName = "decimal(18, 0)")]
            public decimal ItemPrice { get; set; } 



    }
}
