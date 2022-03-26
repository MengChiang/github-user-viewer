using TEONAPI.Models.Repository.Entities;
namespace TEONAPI.Models.Repository.Interfaces
{
    public interface IGitHubRepository
    {
        Task<IEnumerable<User>> GetUsers();
    }
}