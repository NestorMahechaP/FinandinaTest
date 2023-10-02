using BancoFinandina.Service.Queries.DTOs;

namespace BancoFinandina.Service.Queries.Interfaces
{
    public interface IBancoFinandinaQueryService
    {
        void AddUser(UserDto userDto);
        Task<IEnumerable<UserDto>> GetUsersAsync();
        Task<bool> SaveAll();
    }
}
