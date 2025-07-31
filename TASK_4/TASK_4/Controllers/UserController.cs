using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using TASK_4.Models;
using TASK_4.Repositories;

namespace TASK_4.Controllers
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddNewUserAsync(string name, string email, string password)
        {
            var user = User.Create(Guid.NewGuid(), name, email, DateTime.Now, true, password);
            try
            {
                await _userRepository.AddUserAsync(user);
            }
            catch (DbUpdateException ex) when (ex.InnerException is PostgresException pgEx && pgEx.SqlState == "23505")
            {
                throw new InvalidOperationException("Email already exists.", ex);
            }
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }
    }
}
