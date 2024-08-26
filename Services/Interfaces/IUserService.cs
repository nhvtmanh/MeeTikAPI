using MeeTikAPI.DTOs;
using MeeTikAPI.Models;

namespace MeeTikAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> Register(RegisterDTO registerDTO);
    }
}
