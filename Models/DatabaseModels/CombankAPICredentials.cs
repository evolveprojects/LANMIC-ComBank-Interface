using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Models.DatabaseModels
{
    public class CombankAPICredentials
    {
        [Key]                       // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment (Identity)
        public int ID { get; set; }

        [Required]                  // NOT NULL
        [Column(TypeName = "VARBINARY(MAX)")]  // Set VARBINARY
        public byte[] InputChanel { get; set; }
        [Required]                  // NOT NULL
        [Column(TypeName = "VARBINARY(MAX)")]  // Set VARBINARY
        public byte[] InputUser { get; set; }
        [Required]                  // NOT NULL
        [Column(TypeName = "VARBINARY(MAX)")]  // Set VARBINARY
        public byte[] OrgAccount { get; set; }
        [Required]                  // NOT NULL
        [Column(TypeName = "VARBINARY(MAX)")]  // Set VARBINARY
        public byte[] Password { get; set; }
        [Required]                  // NOT NULL
        [Column(TypeName = "VARBINARY(MAX)")]  // Set VARBINARY
        public byte[] Username { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
