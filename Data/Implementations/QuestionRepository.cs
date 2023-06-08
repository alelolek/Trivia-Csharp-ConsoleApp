
using CrossCutting.Dto;
using CrossCutting.Enum;
using Data.Interfaces;

namespace Data.Implementations
{
    public class QuestionRepository : IQuestionRepository
    {
        private IJsonManager _jsonManager;

        public QuestionRepository()
        {
            _jsonManager = new JsonManager();
        }

        public List<Question> ListQuestion(Func<Question, bool>? filter = null)
        {
            List<Question> questions = _jsonManager.ReadFile<Question>("Questions.json");
            if (filter == null)
                return questions;
            else
                return questions.Where(filter).ToList();
        }
    }
}
