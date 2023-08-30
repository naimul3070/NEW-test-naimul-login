using Microsoft.EntityFrameworkCore;

namespace test_naimul.DbContexts;

public partial class ReadWriteContext : DbContext
{
    public ReadWriteContext()
    {
    }

    public ReadWriteContext(DbContextOptions<ReadWriteContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:SQL5104.site4now.net,1433;Initial Catalog=db_a9cc46_naimul007;Persist Security Info=False;User ID=db_a9cc46_naimul007_admin;Password=N@imul007;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
