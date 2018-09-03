using System.Data.Entity.ModelConfiguration;

namespace Vidly.Models.Configurations
{
    public class MoviesConfiguration : EntityTypeConfiguration<Movie>
    {
        public MoviesConfiguration()
        {
            Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(m => m.ReleaseDate)
                .IsRequired();

            Property(m => m.DateAdded)
                .IsRequired();

            HasRequired(m => m.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(m => m.GenreId);
        }
    }
}