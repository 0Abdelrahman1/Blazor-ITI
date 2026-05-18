using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SharedEntities;

namespace WebAPI_DataAccessLayer_EF.Contexts
{
    public class InternshipDB : DbContext
    {
        public InternshipDB(DbContextOptions<InternshipDB> options) : base(options)
        { }

        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
    }
}
