using System;
using System.Collections.Generic;
using Domain.Common;

namespace Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}