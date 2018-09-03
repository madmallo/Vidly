using System.Data.Entity.ModelConfiguration;

namespace Vidly.Models.Configurations
{
    public class GenresConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenresConfiguration()
        {
            Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasMany(g => g.Movies)
                .WithRequired(m => m.Genre)
                .HasForeignKey(m => m.GenreId);
        }
    }
}