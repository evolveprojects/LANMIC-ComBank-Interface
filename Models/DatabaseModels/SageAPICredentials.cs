using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Models.DatabaseModels
{
    public class SageAPICredentials
    {
        [Key]                       // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment (Identity)
        public int ID { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string URL { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string Company { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string Username { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string Password { get; set; }
     
     
    }
}
