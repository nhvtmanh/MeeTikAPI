using MeeTikAPI.DTOs;
using MeeTikAPI.Models;

namespace MeeTikAPI.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetById(Guid id);
        Task<User?> GetByEmail(string email);
        Task<User?> GetByPhoneNumber(string phoneNumber);
        Task<User?> Create(RegisterDTO registerDTO);
    }
}
