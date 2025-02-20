using System.Data.Entity;
using System.Data.Entity;
namespace WindowsFormsApp2
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentDBConnectionString")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
