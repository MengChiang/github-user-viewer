using TEONAPI.Models.Repository;
using TEONAPI.Models.Repository.Interfaces;
using TEONAPI.Models.Repository.Entities;
using TEONAPI.Models.Services.Interfaces;

namespace TEONAPI.Models.Services
{
    public class GitHubService : IGitHubService
    {
        private readonly IGitHubRepository _gitHubRepository;

        public GitHubService(IGitHubRepository gitHubRepository)
        {
            this._gitHubRepository = gitHubRepository;
        }
        public IEnumerable<User> GetUsers()
        {
            return _gitHubRepository.GetUsers().GetAwaiter().GetResult();
        }
    }
}
