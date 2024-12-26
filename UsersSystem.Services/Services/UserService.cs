using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersSystem.Data.Models;
using UsersSystem.Data.Repositories;
using Serilog;

namespace UsersSystem.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;
        public UserService(IUserRepository userRepository, ILogger logger)
        {
            _userRepository = userRepository;
            _logger = logger;

        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<User> GetUserById(int userId)
        {
            return await _userRepository.GetUserById(userId);
        }

        public async Task<int> AddUser(User user, IBrowserFile image)
        {
            int result;
            try
            {
                int UserId = await _userRepository.AddUser(user);
                _logger.Information($"The added user has ID {UserId}");
                if (UserId < 0) 
                {
                    _logger.Information($"User didn't added successfully");
                    return -1; 
                }

                result = await ImageUpload(image, UserId);
                _logger.Information($"Image uploded");

                return result;
            }
            catch (Exception ex) 
            {
                _logger.Information($"User didn't added");
                _logger.Error(ex.Message);
                result = -1;
            }
            return 0;
        }

        public async Task UpdateUser(User user)
        {
            await _userRepository.UpdateUser(user);
        }

        public async Task DeleteUser(int userId)
        {
            await _userRepository.DeleteUser(userId);
        }

        private async Task<int> ImageUpload(IBrowserFile image, int ID)
        {
            try
            {
                var savePath = Path.Combine("D:\\Blazor Course\\Codeline\\Day 9\\Photos", ID + ".jpg"); // Change this to your desired path

                // Ensure the uploads directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(savePath));

                // Save the image to the specified path
                using (var fileStream = new FileStream(savePath, FileMode.Create))
                {
                    await image.OpenReadStream().CopyToAsync(fileStream);
                }



                return 1;
            }
            catch (Exception ex) {

                return -1;
            }
        }
    }
}
