using BlazorBasicsDay1_Hosted.Client.Models;

namespace BlazorBasicsDay1_Hosted.Client.Services
{
    public interface IProductService
    {
        List<string> GetProducts();

        Task<List<ProductsModel>> GetProductsAsync();
        Task<bool> AddProductAsync(ProductsModel product);
        Task<ProductsModel> GetProductByIdAsync(int id);
        Task UpdateProductAsync(ProductsModel product);
        Task DeleteProductAsync(int id);
    }
}
