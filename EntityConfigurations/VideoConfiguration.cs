using System.Data.Entity.ModelConfiguration;

namespace EFCourse.Vidzy.EntityConfigurations
{
    class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            ToTable("Videos");

            HasKey(v => v.Id);

            Property(v => v.Name)
            .IsRequired()
            .HasMaxLength(255);

            HasRequired(v => v.Genre)
            .WithMany(g => g.Videos)
            .HasForeignKey(v => v.GenreId);

            Property(v => v.Clasification)
            .HasColumnType("tinyint");
        }
    }
}
