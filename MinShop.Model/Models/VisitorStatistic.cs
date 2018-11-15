using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinShop.Model.Models
{
    [Table("VisitorStatistics")]
    class VisitorStatistic
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public DateTime VisitedDate { get; set; }
        
        [MaxLength(50)]
        public string IDAddress { get; set; }
    }
}
