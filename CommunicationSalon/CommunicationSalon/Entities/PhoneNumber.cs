using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    [Table("PhoneNumber")]
    public class PhoneNumber
    {
        [Key]
        [StringLength(20)]
        public string Number { get; set; }
        public virtual Tariff Tariff { get; set; }
        [Required]
        [ForeignKey("Tariff")]
        public virtual int TariffId { get; set; }
        public virtual User User { get; set; }
        [Required]
        [ForeignKey("User")]
        public virtual int UserId { get; set; }
        [Required]
        public decimal Balance { get; set; }
        public PhoneNumber() { }
        public PhoneNumber(string Number, int TariffId, int UserId, decimal Balance)
        {
            this.Number = Number;
            this.TariffId = TariffId;
            this.UserId = UserId;
            this.Balance = Balance;
        }
    }
}
