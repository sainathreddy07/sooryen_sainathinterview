using CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace CodeTest.Dacs
{
    public class CodeTestDac : IDisposable
    {
        public UserModel GetUser(UserModel model)
        {
            using(var dbContext = new CodeTestContext())
            {
                ((IObjectContextAdapter)dbContext).ObjectContext.Connection.Open();

                var users = (from m in dbContext.Users select m).ToList();

                UserModel user = (from m in dbContext.Users
                                  where m.UserName == model.UserName && m.Password == model.Password
                                  select new UserModel()
                                  {
                                      Id = m.Id,
                                      UserName = m.UserName
                                  }).FirstOrDefault();

                return user;
            }

        }

        public List<NoteModel> GetNotes(string  userId)
        {
            using (var dbContext = new CodeTestContext())
            {
                ((IObjectContextAdapter)dbContext).ObjectContext.Connection.Open();

               List<NoteModel> notes = (from m in dbContext.Notes
                                  where m.UserId == userId
                                  select new NoteModel()
                                  {
                                      Id = m.Id,
                                      Content = m.Content,
                                      Topic = m.Topic,
                                      UserId = m.UserId
                                  }).ToList();

                return notes;
            }

        }

        public void Dispose()
        {
           // throw new NotImplementedException();
        }
    }
}