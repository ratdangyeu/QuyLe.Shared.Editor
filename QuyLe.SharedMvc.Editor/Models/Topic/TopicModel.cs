using System.ComponentModel.DataAnnotations;

namespace QuyLe.SharedMvc.Editor.Models
{
    public class TopicModel : BaseModel
    {
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }
        
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public string ParentId { get; set; }

        public string Path { get; set; }

        [Required]
        public bool InUse { get; set; }

        public TopicModel()
        {
            InUse = true;
        }
    }
}
