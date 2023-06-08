
using CrossCutting.Dto;
using CrossCutting.Enum;

namespace Data.Interfaces
{
    public interface IQuestionRepository
    {
        public List<Question> ListQuestion(Func<Question, bool> filter);
    }
}
