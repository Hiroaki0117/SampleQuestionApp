using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace SampleQuestionApp.Models
{
    public partial class MvcdbContext : DbContext
    {
        public MvcdbContext() { }

        public MvcdbContext(DbContextOptions<MvcdbContext> options) : base(options) { }

        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
    }
}
