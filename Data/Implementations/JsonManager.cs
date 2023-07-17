using System.Text;
using Data.Interfaces;
using Newtonsoft.Json;

namespace Data.Implementations
{
    public class JsonManager : IJsonManager
    {
        private string basePath = "../../../../Data/Files";
        public List<T> ReadFile<T>(string filename)
        {
            var fullPath = Path.Combine(basePath, filename);
            string contenJson = File.ReadAllText(fullPath);
            List<T> listObject;
            
            try
            {
                listObject = JsonConvert.DeserializeObject<List<T>>(contenJson);
            }
            catch (JsonException ex)
            {
                throw new Exception("Error al deserializar el archivo", ex);
            }

            if (listObject == null)
            {
                throw new Exception("El archivo está vacío");
            }

            return listObject;
        }
    }
}
