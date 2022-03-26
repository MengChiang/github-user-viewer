using TEONAPI.Models.Repository.Interfaces;
using TEONAPI.Models.Repository.Entities;
using System.Net.Http.Headers;

namespace TEONAPI.Models.Repository
{
    public class GitHubRepository : IGitHubRepository
    {
        public async Task<IEnumerable<User>> GetUsers()
        {
            IEnumerable<User>? users = new List<User>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.github.com/");
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TEON", "v1"));

                var request = new HttpRequestMessage(HttpMethod.Get, "users");

                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    users = response.Content.ReadFromJsonAsync<IEnumerable<User>>().Result;
                }
            }

            return users;
        }
    }
}
