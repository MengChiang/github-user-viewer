using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace UserViewer
{
    public class GitHubService
    {
        public async Task<List<User>> GetUsers()
        {
            IEnumerable<User>? users = new List<User>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.github.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TEON", "v2"));
                var response = await client.GetAsync("users").ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    var dataString = response.Content.ReadAsStringAsync().Result;
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    users = JsonSerializer.Deserialize<IEnumerable<User>>(dataString, options);
                }
            }

            return (List<User>)users;
        }
    }

    public class User
    {
        public string? Login { get; set; }
        public int Id { get; set; }
        public string? Node_Id { get; set; }
        public string? Avatar_Url { get; set; }
        public string? Gravatar_Id { get; set; }
        public string? Url { get; set; }
        public string? Html_Url { get; set; }
        public string? Followers_Url { get; set; }
        public string? Following_Url { get; set; }
        public string? Gists_Url { get; set; }
        public string? Starred_Url { get; set; }
        public string? Subscriptions_Url { get; set; }
        public string? Organizations_Url { get; set; }
        public string? Repos_Url { get; set; }
        public string? Events_Url { get; set; }
        public string? Received_Events_Url { get; set; }
        public string? Type { get; set; }
        public bool Site_Admin { get; set; }
    }
}
