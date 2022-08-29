using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace asibproject.Data
{
    public class QuestionDAL
    {
        private static readonly ApplicationContext db = new ApplicationContext();

        //this method will get all the question record
        public static IEnumerable<Question> GetAllQuestions()
        {
            try
            {
                return db.Questions.OrderBy(q => q.TextQuestion)
                               .ToList();
            }
            catch
            {
                throw;
            }

        }

        //this method will add a new question 
        public int CreateQuestion(Question question)
        {
            try
            {
                db.Questions.Add(question);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }


        }
        //this method will update the existing question record    
        public int UpdateQuestion(int id, Question question)
        {
            try
            {
                db.Entry(question).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }

        }
        //this method will get detail of a specific question
        public Question GetQuestionData(int id)
        {
            try
            {
                Question question = db.Questions.Find(id);
                return question;
            }
            catch
            {
                throw;
            }

        }
        //this method will delete the specifig user record    
        public int DeleteQuestion(int id)
        {
            try
            {
                Question qmp = db.Questions.Find(id);
                db.Questions.Remove(qmp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }

        }

    }
}
