using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Models.DatabaseModels
{
    public class UserAuthority
    {
        [Key]                       // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto Increment (Identity)
        public int ID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]                  // NOT NULL
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]  // Set NVARCHAR
        public string FormID { get; set; }
        [Required]
        public int PermissionID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
