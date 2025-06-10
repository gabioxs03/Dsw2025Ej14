using System.Text.Json;
using Dsw2025Ej14.Api.Domain;


namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria: IPersistencia
    {
        private List<Product> _products = new List<Product>();
        private void LoadProducts()
        {
            var json = File.ReadAllText("Data\\products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            }) ?? [];
            ;
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public List<Product> GetProducts(string sku)
        {
            return _products;
        }
    }
}
