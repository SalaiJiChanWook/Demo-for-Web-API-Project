using Demo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Demo.WebApi.Models;
using Demo.WebApi.Models.ApiModels;

namespace Demo.WebApi
{
    public class DemoApiClientService
    {
        private readonly HttpClient _httpClient;

        public DemoApiClientService(ApiClientOptions apiClientOptions)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri(apiClientOptions.ApiBaseAddress);

        }

        public async Task<List<Product>?> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>?>("/api/Product");
        }

        public async Task<Product?> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product?>($"/api/Product/{id}");
        }

        public async Task SaveProduct(Product product)
        {
            await _httpClient.PostAsJsonAsync("/api/Product", product);
        }


        public async Task UpdateProduct(Product product)
        {
            await _httpClient.PutAsJsonAsync("/api/Product", product);
        }

        public async Task deleteProduct(int id)
        {
            await _httpClient.DeleteAsync($"/api/Product/{id}");
        }
    }
}
