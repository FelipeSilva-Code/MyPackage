using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MySQLDBContext : DbContext
    {
        public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options) { }

        public DbSet<UserEntity> User { get; set; }
        public DbSet<PackageEntity> Package { get; set; }

    }
}
