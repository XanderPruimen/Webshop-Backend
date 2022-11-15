﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Webshop_Backend.Models;

namespace Webshop_Backend.DTO_s
{
    [Table(name: "Orders")]
    public class OrderDTO
    {
        [Key]
        public int OrderID { get; set; }
        
        public virtual UserDTO User { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string Count { get; set; } = string.Empty;
/*        public virtual ICollection<ItemDTO> Items { get; set; }*/

    }
}
