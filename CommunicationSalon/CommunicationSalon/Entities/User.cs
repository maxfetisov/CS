using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        public Gender Gender { get; set; }
        [Required]
        [ForeignKey("Gender")]
        public int GenderId { get; set; }
        [Required]
        [StringLength(200)]
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public User() { }
        public User(string LastName, string FirstName, string MiddleName, int GenderId, string Email)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.GenderId = GenderId;
            this.Email = Email;
        }
        public User(int Id, string LastName, string FirstName, string MiddleName, int GenderId, string Email)
        {
            this.Id = Id;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.GenderId = GenderId;
            this.Email = Email;
        }
    }
}
