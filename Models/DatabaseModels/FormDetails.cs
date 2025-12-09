using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Models.DatabaseModels
{
    public class FormDetails
    {
        [Key]                       // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment (Identity)
        public int ID { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string FormID { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]  // Set NVARCHAR
        public string FormName { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string FormDescription { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
