using LearnDapper.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;

namespace LearnDapper.Entities.DataContextfolder
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Post> Posts => Set<Post>();

        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<PostDetail> PostDetails => Set<PostDetail>();

        public IDbConnection Connection => Database.GetDbConnection();


        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }

        public async Task<int> SaveSchangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
