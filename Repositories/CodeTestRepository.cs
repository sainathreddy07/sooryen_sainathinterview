using CodeTest.Dacs;
using CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.Repositories
{
    public class CodeTestRepository: IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public UserModel GetUser(UserModel model)
        {
            using (var dac = new CodeTestDac()) {

                var user = dac.GetUser(model);
                return user;
            }
        }

        public List<NoteModel> GetNotes(string  userId)
        {
            using (var dac = new CodeTestDac())
            {
                var notes = dac.GetNotes(userId);
                return notes;
            }
        }
    }
}