using TEONAPI.Models.Repository.Entities;

namespace TEONAPI.Models.Services.Interfaces
{
    public interface IGitHubService
    {
        IEnumerable<User> GetUsers();
    }
}