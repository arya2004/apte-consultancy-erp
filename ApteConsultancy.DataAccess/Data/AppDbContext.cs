using ApteConsultancy.Models;
using ApteConsultancy.Models.Master;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApteConsultancy.DataAccess.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<EmployeeUser> EmployeeUsers { get; set; }
        public DbSet<AssociateUser> AssociateUsers { get; set; }
        //public DbSet<Architect> Architects { get; set; }
        //public DbSet<Client> Clients { get; set; }
        //public DbSet<Company> Companies { get; set; }
        //public DbSet<Project> Projects { get; set; }
        //public DbSet<Drawing> Drawings { get; set; }
        //public DbSet<DrawingRevision> DrawingRevisions { get; set; }
        //public DbSet<EmployeeTimeSheet> EmployeeTimeSheets { get; set; }
        //public DbSet<OwnCarLocalAndOutStation> OwnCarLocalAndOutStations { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AssociateUser>(entity => { entity.ToTable("Associate"); });
            builder.Entity<EmployeeUser>(entity => { entity.ToTable("EMployee"); });

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }

    }
}
