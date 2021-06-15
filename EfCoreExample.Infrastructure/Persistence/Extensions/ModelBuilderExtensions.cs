using Microsoft.EntityFrameworkCore;

namespace EfCoreExample.Infrastructure.Persistence.Extensions
{
    public static class ModelBuilderExtensions 
    {
        public static void SetSingularizedTableNames(this ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }
        }
    }
}
