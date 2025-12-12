using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Models.DatabaseModels
{
    public class Vender
    {
        [Key]                       // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment (Identity)
        public int Id { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string VendorNumber { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string VendorName { get; set; }
    
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string BankName { get; set; }
               
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string SWIFT_Code { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string Email { get; set; }
        public DateTime Created_At { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;

        //public Vender() {
        //    VendorNumber = string.Empty;
        //    VendorName = string.Empty;
        //    BankCode = string.Empty;
        //    Email = string.Empty;

        //}

    }
}
