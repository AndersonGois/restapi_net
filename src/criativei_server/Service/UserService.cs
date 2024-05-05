using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserService
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<UserEntity>> GetUsersAsync()
    {
        return await _userRepository.GetUsersAsync();
    }

    public async Task<UserEntity> GetUserAsync(string id)
    {
        return await _userRepository.GetUserAsync(id);
    }

    public async Task<UserEntity> CreateUserAsync(UserEntity user)
    {
        return await _userRepository.CreateUserAsync(user);
    }

    public async Task UpdateUserAsync(string id, UserEntity userIn)
    {
        await _userRepository.UpdateUserAsync(id, userIn);
    }

    public async Task DeleteUserAsync(string id)
    {
        await _userRepository.DeleteUserAsync(id);
    }
}