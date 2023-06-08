
using CrossCutting.Dto;
using CrossCutting.Enum;

namespace Business.Interfaces
{
    public interface IQuestionService
    {
        public List<Question> ListQuestionByCategory(Category category);
        public List<Question> ListQuestionBySearch(string search);
    }
}
