using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("OrderStatus")]
    class OrderStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public OrderStatus() { }
        public OrderStatus(string Name)
        {
            this.Name = Name;
        }
        public OrderStatus(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
