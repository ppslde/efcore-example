using System;

namespace EfCoreExample.Application.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Changed { get; set; }
    }
}
