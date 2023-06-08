
namespace Data.Interfaces
{
    public interface IJsonManager
    {
        public List<T> ReadFile<T>(string filename);
    }
}
