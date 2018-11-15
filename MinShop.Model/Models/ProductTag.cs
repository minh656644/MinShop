using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinShop.Model.Models
{
    [Table("ProductTags")]
    internal class ProductTag
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TagID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("PostID")]
        public virtual Tag Tag { get; set; }
    }
}