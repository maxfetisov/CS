using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("Gender")]
    class Gender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Consumer> Consumers { get; set; }
        public Gender() { }
        public Gender(string Name) 
        {
            this.Name = Name;
        }
        public Gender(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
