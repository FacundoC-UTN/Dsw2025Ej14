
using System.Text.Json;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria : IPersistencia
    {
        private List<Product> _productos = new();

        public PersistenciaEnMemoria()
        {
            LoadProducts();   
        }

        public IEnumerable<Product> GetProducts()
        {

            return _productos.Where(p =>p.IsActive);


        }

        public void LoadProducts()
        {
            var json = File.ReadAllText("Data/products.json");
            _productos = JsonSerializer
                            .Deserialize<List<Product>>(json)
                        ?? new List<Product>();
        }

        public IEnumerable<Product> GetProductos()
            => _productos.Where(p => p.IsActive);

        public Product GetProduct(string sku)
            => _productos.FirstOrDefault(p => p.Sku == sku);
    }
}


