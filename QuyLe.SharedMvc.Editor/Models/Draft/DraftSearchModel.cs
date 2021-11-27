using System;

namespace QuyLe.SharedMvc.Editor.Models
{
    public class DraftSearchModel : BaseSearchModel
    {
        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }
    }
}
