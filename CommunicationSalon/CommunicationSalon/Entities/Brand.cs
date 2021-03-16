using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("Brand")]
    class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Brand() { }
        public Brand(string Name)
        {
            this.Name = Name;
        }
        public Brand(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
