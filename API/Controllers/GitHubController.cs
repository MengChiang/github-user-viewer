using Microsoft.AspNetCore.Mvc;
using TEONAPI.Models.Repository.Entities;
using TEONAPI.Models.Services.Interfaces;

namespace TEONAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitHubController : Controller
    {
        readonly IGitHubService _gitHubService;
        public GitHubController(IGitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> GetUsers()
        {
            return _gitHubService.GetUsers();
        }



    }
}
