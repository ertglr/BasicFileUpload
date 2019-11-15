using PostedFiles.DataAccessLayer.Initializer;
using PostedFiles.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostedFiles.DataAccessLayer.Context
{
    public class ProjectContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.Connection.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=PostedFileDB;Integrated Security=SSPI;";
            Database.SetInitializer<ProjectContext>(new ProjectInitializer());
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
