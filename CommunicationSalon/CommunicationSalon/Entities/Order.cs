using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        [Required]
        public virtual decimal Price { get; set; }
        public virtual User User { get; set; }
        [Required]
        [ForeignKey("User")]
        public virtual int UserId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        [Required]
        [ForeignKey("OrderStatus")]
        public virtual int OrderStatusId { get; set; }
        public virtual ICollection<ProductInOrder> ProductInOrders { get; set; }
        public Order() { }
        public Order(int Id) 
        {
            this.Id = Id;
        }
        public Order(DateTime StartDate, DateTime FinishDate, decimal Price, int UserId, int OrderStatusId)
        {
            this.StartDate = StartDate;
            this.FinishDate = FinishDate;
            this.Price = Price;
            this.UserId = UserId;
            this.OrderStatusId = OrderStatusId;
        }
        public Order(int Id, DateTime StartDate, DateTime FinishDate, decimal Price, int UserId, int OrderStatusId)
        {
            this.Id = Id;
            this.StartDate = StartDate;
            this.FinishDate = FinishDate;
            this.Price = Price;
            this.UserId = UserId;
            this.OrderStatusId = OrderStatusId;
        }
    }
}
