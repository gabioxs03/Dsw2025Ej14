using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public interface IPersistencia
    {

        public List<Product> GetProducts();

        public List<Product> GetProducts(string sku);
    }

}
