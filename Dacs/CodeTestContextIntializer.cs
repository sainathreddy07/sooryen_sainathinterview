using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeTest.Dacs.Entities;

namespace CodeTest.Dacs
{
    public class CodeTestContextIntializer: DropCreateDatabaseIfModelChanges<CodeTestContext>
    {

        protected override void Seed(CodeTestContext context)
        {
            context.Users.Add(new UserEntities()
            {
                UserName = "test",
                Password = "test"
            });

            context.SaveChanges();

            context.Notes.Add(new NoteEntities()
            {
                Id = 1,
                Content = "Hello"
            });

            context.SaveChanges();

           base.Seed(context);
        }
    }
}