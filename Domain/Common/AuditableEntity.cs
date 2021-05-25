using System;

namespace Domain.Common
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}