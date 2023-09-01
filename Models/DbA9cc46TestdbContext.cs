using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace test_naimul.Models;

public partial class DbA9cc46TestdbContext : DbContext
{
    public DbA9cc46TestdbContext()
    {
    }

    public DbA9cc46TestdbContext(DbContextOptions<DbA9cc46TestdbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SQL5104.site4now.net;Database=db_a9cc46_testdb;User ID=db_a9cc46_testdb_admin;Password=1234@Abcd;Trusted_Connection=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
