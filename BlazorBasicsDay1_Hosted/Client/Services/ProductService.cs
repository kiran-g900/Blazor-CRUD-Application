using BlazorBasicsDay1_Hosted.Client.Models;
using System.Net.Http.Json;

namespace BlazorBasicsDay1_Hosted.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }        

        public List<string> GetProducts()
        {
            return new List<string> { "Mobile", "Laptop", "Camera", "Headphoes", "TV" };
        }

        public async Task<List<ProductsModel>> GetProductsAsync()
        {
            return await _http.GetFromJsonAsync<List<ProductsModel>>("api/Product");
        }

        public async Task<bool> AddProductAsync(ProductsModel product)
        {
            //await _http.PostAsJsonAsync("api/Product", product);
            var response = await _http.PostAsJsonAsync("api/Product", product);
            return response.IsSuccessStatusCode;
        }

        public async Task<ProductsModel?> GetProductByIdAsync(int id)
        {
            try
            {
                var response = await _http.GetAsync("api/Product/" + id);
                if(response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<ProductsModel>();
                }

                return null;
            }
            catch (Exception ex)
            {                
                return null;
            }
        }

        public async Task UpdateProductAsync(ProductsModel product)
        {
            await _http.PutAsJsonAsync("api/Product", product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _http.DeleteAsync($"api/Product/{id}");
        }
    }
}
