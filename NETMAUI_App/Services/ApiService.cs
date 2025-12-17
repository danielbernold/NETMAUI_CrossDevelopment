using NETMAUI_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NETMAUI_App.Services
{
    public class ApiService
    {
        private readonly HttpClient _client = new();

        public async Task<List<Posts>> GetPostsAsync()
        {
            var url = "https://jsonplaceholder.typicode.com/posts";
            var response = await _client.GetFromJsonAsync<List<Posts>>(url);
            return response ?? new List<Posts>();
        }
    }
}
