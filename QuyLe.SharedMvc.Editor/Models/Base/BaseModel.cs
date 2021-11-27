using System;

namespace QuyLe.SharedMvc.Editor.Models
{
    public class BaseModel
    {
        public virtual string Id { get; set; } = Guid.NewGuid().ToString("D");
    }
}
