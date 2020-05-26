using System.Data.Entity.ModelConfiguration;

namespace EFCourse.Vidzy.EntityConfigurations
{
    class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            ToTable("Genres");

            HasKey(g => g.Id);

            Property(g => g.Name)
            .IsRequired()
            .HasMaxLength(255);

        }
    }
}
