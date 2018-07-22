using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeTest.Dacs.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CodeTest.Dacs.Mappings
{
    public class Note_Map: EntityTypeConfiguration<NoteEntities>
    {
        public Note_Map()
        {
            ToTable("notes", "stackdb");
            HasKey(m => m.Id);

            Property(m => m.Id).HasColumnName("id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.UserId).HasColumnName("userid");
            Property(m => m.Topic).HasColumnName("topic");
            Property(m => m.Content).HasColumnName("content_data");
        }
    }
}