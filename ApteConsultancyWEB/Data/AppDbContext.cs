using ApteConsultancyWEB.Models;
using ApteConsultancyWEB.Models.Master;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApteConsultancyWEB.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<EmployeeUser> Employees { get; set; }
        public DbSet<AssociateUser> AssociateUsers { get; set; }
        public DbSet<Architect> Architects { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Drawing> Drawings { get; set; }
        public DbSet<DrawingRevision> DrawingRevisions { get; set; }
        public DbSet<EmployeeTimeSheet> EmployeeTimeSheets { get; set; }
        public DbSet<OwnCarLocalAndOutStation> OwnCarLocalAndOutStations { get; set; }

    }
}
