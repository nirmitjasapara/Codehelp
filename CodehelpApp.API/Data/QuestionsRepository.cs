using System.Collections.Generic;
using System.Threading.Tasks;
using CodehelpApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CodehelpApp.API.Data
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly DataContext _context;
        public QuestionsRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Question> GetQuestion(int id)
        {
            var question = await _context.Questions.FirstOrDefaultAsync(q => q.Id == id);

            return question;
        }

        public async Task<IEnumerable<Question>> GetQuestions()
        {
            var questions = await _context.Questions.ToListAsync();

            return questions;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}