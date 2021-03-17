using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("Consumer")]
    public class Consumer
    {
        [Key]
        [StringLength(200)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        public virtual RoleConsumer RoleConsumer { get; set; }
        [Required]
        [ForeignKey("RoleConsumer")]
        public virtual int RoleConsumerId { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        public virtual Gender Gender { get; set; }
        [Required]
        [ForeignKey("Gender")]
        public virtual int GenderId { get; set; }
        public Consumer() { }
        public Consumer(string Email, string Password, int RoleConsumerId, string LastName, string FirstName, string MiddleName, int GenderId) 
        {
            this.Email = Email;
            this.Password = Password;
            this.RoleConsumerId = RoleConsumerId;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.GenderId = GenderId;
        }
    }
}
