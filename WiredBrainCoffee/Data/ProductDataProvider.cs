using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Documents;
using WiredBrainCoffee.Model;

namespace WiredBrainCoffee.Data
{
    public interface IProductDataProvider
    {
        Task<IEnumerable<Product>?> GetAllAsync();
    }

    public class ProductDataProvider : IProductDataProvider
    
    {
        public async Task<IEnumerable<Product>?> GetAllAsync()
        {
            await Task.Delay(100);

            return new List<Product>
            {
                new Product { Name="Cappuccino", Description="Espresso with milk" },
                new Product { Name="Espresso", Description="Pure coffee" },
                new Product { Name="Latte", Description="Light shit" }
            };
        }
    }
}
