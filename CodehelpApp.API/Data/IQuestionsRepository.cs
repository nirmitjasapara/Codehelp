using System.Collections.Generic;
using System.Threading.Tasks;
using CodehelpApp.API.Models;

namespace CodehelpApp.API.Data
{
    public interface IQuestionsRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<Question>> GetQuestions();
         Task<Question> GetQuestion(int id);
    }
}