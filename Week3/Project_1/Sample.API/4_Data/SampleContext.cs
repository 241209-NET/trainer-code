using Microsoft.EntityFrameworkCore;
using Sample.API.Model;

namespace Sample.API.Data;

public class SampleContext : DbContext
{
    public SampleContext(){}
    public SampleContext(DbContextOptions<SampleContext> options) : base(options){}

    public DbSet<Student> Students { get; set; }
}