using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SocialMediaApp.Console.Models;

namespace SocialMediaApp.Console.Repositories
{
    public class PostRepository
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";



        public async Task<IReadOnlyList<Post>> GetByUserIdAsync(int userId)
        {
            Task.Delay(8000).Wait();

            using var client = new HttpClient();
            var response = await client.GetAsync($"{Url}/?userId={userId}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IReadOnlyList<Post>>(content);



        }
    }
}
