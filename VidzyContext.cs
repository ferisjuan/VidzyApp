using System.Data.Entity;

namespace EFCourse.Vidzy
{
    class VidzyContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
