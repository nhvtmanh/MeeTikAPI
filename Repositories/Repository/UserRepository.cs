using MeeTikAPI.Data;
using MeeTikAPI.DTOs;
using MeeTikAPI.Models;
using MeeTikAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace MeeTikAPI.Repositories.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetById(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User?> GetByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User?> GetByPhoneNumber(string phoneNumber)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }

        public async Task<User?> Create(RegisterDTO registerDTO)
        {
            User user = new User
            {
                Id = Guid.NewGuid(),
                Email = registerDTO.Email,
                PasswordHash = registerDTO.Password,
                PhoneNumber = registerDTO.PhoneNumber,
                FullName = registerDTO.FullName,
                Birthday = registerDTO.Birthday,
                Gender = registerDTO.Gender,
                RoleId = registerDTO.RoleId,
                AvatarURL = registerDTO.AvatarURL
            };
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
