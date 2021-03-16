using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("RoleConsumer")]
    class RoleConsumer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public virtual ICollection<Consumer> Consumers { get; set; }
        public RoleConsumer() { }
        public RoleConsumer(string Name)
        {
            this.Name = Name;
        }
        public RoleConsumer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
