using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace fullMVCProject.Models
{
    public class CategoryModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage="Display Order must be between 1 and 100 only!")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}