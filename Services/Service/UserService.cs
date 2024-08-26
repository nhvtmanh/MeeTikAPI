using MeeTikAPI.DTOs;
using MeeTikAPI.Models;
using MeeTikAPI.Repositories.Interfaces;
using MeeTikAPI.Services.Interfaces;

namespace MeeTikAPI.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> Register(RegisterDTO registerDTO)
        {
            // Check if email or phone number already exists
            var existingUserByEmail = await _userRepository.GetByEmail(registerDTO.Email);
            if (existingUserByEmail != null)
            {
                throw new ArgumentException("Email already exists");
            }

            var existingUserByPhoneNumber = await _userRepository.GetByPhoneNumber(registerDTO.PhoneNumber);
            if (existingUserByPhoneNumber != null)
            {
                throw new ArgumentException("Phone number already exists");
            }

            // Create user
            return await _userRepository.Create(registerDTO);
        }
    }
}
