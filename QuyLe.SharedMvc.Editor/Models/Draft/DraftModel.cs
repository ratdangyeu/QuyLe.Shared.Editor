using System;
using System.ComponentModel.DataAnnotations;

namespace QuyLe.SharedMvc.Editor.Models
{
    public class DraftModel : BaseModel
    {
        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Reference { get; set; }

        public string TopicId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
