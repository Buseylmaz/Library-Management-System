using System.Data.Entity;

namespace LibraryManagementSystem
{
    class LibrariesContext:DbContext
    {
        public DbSet<Library> Library { get; set; }
    }
}
