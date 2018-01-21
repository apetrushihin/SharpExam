namespace SharpExam.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationModel : DbContext
    {
        public ApplicationModel()
            : base("name=ApplicationModel")
        {
        }

        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

        }
    }
}
