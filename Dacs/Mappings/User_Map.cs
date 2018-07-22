using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using CodeTest.Dacs.Entities;


namespace CodeTest.Dacs.Mappings
{
    public class User_Map: EntityTypeConfiguration<UserEntities>
    {

        public User_Map()
        {
            ToTable("users", "stackdb");
            HasKey(m => m.Id);

            Property(m => m.Id).HasColumnName("id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.UserName).HasColumnName("username");
            Property(m => m.Password).HasColumnName("password");
        }
    }
}