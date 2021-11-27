using System.ComponentModel.DataAnnotations;

namespace QuyLe.SharedMvc.Editor.Models
{
    public class ParagraphModel : BaseModel
    {
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public string CategoryId { get; set; }

        [Required]
        public bool InUse { get; set; }

        public ParagraphModel()
        {
            InUse = true;
        }
    }
}
