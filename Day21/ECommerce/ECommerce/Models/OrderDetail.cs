using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    [Table("OrderDetails")]
    internal class OrderDetail
    {
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
