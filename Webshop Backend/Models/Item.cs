namespace Webshop_Backend.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Price { get; set; } = string.Empty;
        public string ItemInfo { get; set; } = string.Empty;
        //public virtual ICollection<Order> Orders { get; set; }
        //        public string EAN { get; set; } = string.Empty;
    }
}
