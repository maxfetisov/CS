using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("ProductInOrder")]
    public class ProductInOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public virtual Order Order { get; set; }
        [Required]
        [ForeignKey("Order")]
        public virtual int OrderId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        [ForeignKey("Product")]
        public virtual string ProductArticle { get; set; }
        [Required]
        public int Count { get; set; }
        public ProductInOrder() { }
        public ProductInOrder(int OrderId, string ProductArticle, int Count) 
        {
            this.OrderId = OrderId;
            this.ProductArticle = ProductArticle;
            this.Count = Count;
        }
        public ProductInOrder(int Id, int OrderId, string ProductArticle, int Count)
        {
            this.Id = Id;
            this.OrderId = OrderId;
            this.ProductArticle = ProductArticle;
            this.Count = Count;
        }
    }
}
