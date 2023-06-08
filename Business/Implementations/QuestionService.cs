
using Business.Interfaces;
using CrossCutting.Dto;
using CrossCutting.Enum;
using Data.Implementations;
using Data.Interfaces;

namespace Business.Implementations
{
    public class QuestionService : IQuestionService
    {
        private IQuestionRepository _questionRepository;

        public QuestionService()
        {
            _questionRepository = new QuestionRepository();
        }

        public List<Question> ListQuestionByCategory(Category category)
        {
            Func<Question, bool> filter = x => x.Category == category;
            var listQuestion = _questionRepository.ListQuestion(filter);
            return listQuestion;
        }

        public List<Question> ListQuestionBySearch(string search)
        {
            Func<Question, bool> filter = x => x.Description.Contains(search);
            var listQuestion = _questionRepository.ListQuestion(filter);
            return listQuestion;
        }

    }
}
