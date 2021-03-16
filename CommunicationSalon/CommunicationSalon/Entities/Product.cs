using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("Product")]
    class Product
    {
        [Key]
        [StringLength(200)]
        public string Article { get; set; }
        public virtual Brand Brand { get; set; }
        [Required]
        [ForeignKey("Brand")]
        public virtual int BrandId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Model { get; set; }
        public virtual TypeProduct TypeProduct { get; set; }
        [Required]
        [ForeignKey("TypeProduct")]
        public virtual int TypeProductId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int QuantityInStock { get; set; }
        public virtual ICollection<ProductInOrder> ProductInOrders { get; set; }
        public Product() { }
        public Product(string Article, int BrandId, string Name, string Model, int TypeProductId, decimal Price, int QuantityInStock) 
        {
            this.Article = Article;
            this.BrandId = BrandId;
            this.Name = Name;
            this.Model = Model;
            this.TypeProductId = TypeProductId;
            this.Price = Price;
            this.QuantityInStock = QuantityInStock;
        }
    }
}
