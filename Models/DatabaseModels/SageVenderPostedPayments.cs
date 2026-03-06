using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Enums;

namespace LANMIC_ComBank_Interface.Models.DatabaseModels
{
    public class SageVenderPostedPayments
    {
        [Key]                       // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment (Identity)
        public int Id { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string DocumentNumber { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string DocumentType { get; set; }

        [Required]
        [Column(TypeName = "decimal(19,3)")]
        public decimal PaymentAmount { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string VendorNumber { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(200)]
        [Column(TypeName = "nvarchar(200)")]  // Set NVARCHAR
        public string VendorName { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string BankAccountNo { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string BankName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string SWIFT_Code { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string CurrencyCode { get; set; }

        [Required]                  // NOT NULL
        [MaxLength(150)]
        [Column(TypeName = "nvarchar(150)")]  // Set NVARCHAR
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime PostingDate { get; set; }

        [Required]
        public PaymentStatus CurrentStatus { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; } = null;
        public bool IsActive { get; set; } = true;


    }
}
