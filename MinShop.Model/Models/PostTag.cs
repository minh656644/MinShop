using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinShop.Model.Models
{
    [Table("PostTags")]
    internal class PostTag
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { get; set; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        [ForeignKey("PostID")]
        public virtual Tag Tag { get; set; }
    }
}