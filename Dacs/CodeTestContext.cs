using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeTest.Dacs.Entities;
using CodeTest.Dacs.Mappings;

namespace CodeTest.Dacs
{
    public class CodeTestContext: DbContext
    {
        public DbSet<UserEntities> Users { get; set; }
        public DbSet<NoteEntities> Notes { get; set; }

        public CodeTestContext():base(nameOrConnectionString: "name=codetestdb")
        {
         //   Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new User_Map());
            modelBuilder.Configurations.Add(new Note_Map());
        }
    }
}