using System.ComponentModel.DataAnnotations;

namespace QuyLe.SharedMvc.Editor.Models
{
    public class DraftDetailModel : BaseModel
    {
        [Required]
        public string ParagraphId { get; set; }

        [Required]
        public int Order { get; set; }

        [Required]
        public string DraftId { get; set; }

        public DraftDetailModel()
        {
            Order = 1;
        }
    }
}
