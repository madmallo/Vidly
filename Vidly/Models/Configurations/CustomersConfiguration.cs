using System.Data.Entity.ModelConfiguration;

namespace Vidly.Models.Configurations
{
    public class CustomersConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomersConfiguration()
        {
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}