using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Models.DatabaseModels
{
    public class SageBanks
    {
        [Key]                       // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment (Identity)
        public int Id { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string BankCode { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(150)")]  // Set NVARCHAR
        public string BankName { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string BankAccountNo { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string CurrencyCode { get; set; }

        public DateTime Created_At { get; set; } = DateTime.Now;



    }
}
