using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("Tariff")]
    class Tariff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Minutes { get; set; }
        [Required]
        public decimal Internet { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public Tariff() { }
        public Tariff(string Name, string Description, decimal Price, int Minutes, decimal Internet)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Minutes = Minutes;
            this.Internet = Internet;
        }
        public Tariff(int Id, string Name, string Description, decimal Price, int Minutes, decimal Internet)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Minutes = Minutes;
            this.Internet = Internet;
        }
    }
}
