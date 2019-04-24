using Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace SharedClassLibraryCSharp
{
    public class QuestionRepository
    {
        private List<Question> Questions;

        public QuestionRepository()
        {
            Questions = InitQuestions();
        }

        public List<Question> GetQuestions()
        {
            return Questions;
        }

        public Question GetFirstQuestion()
        {
            return Questions[0];
        }

        public Question GetNextQuestion(string Id)
        {
            foreach (var question in Questions)
            {
                if (question.Id.Equals(Id)) { return question; }
            }

            return null;
        }

        private List<Question> InitQuestions()
        {
            string json = Properties.Resources.Questions_json;
            List<Question> questions = new List<Question>();
            questions = JsonConvert.DeserializeObject<List<Question>>(json);

            return questions;
        }
    }
}
