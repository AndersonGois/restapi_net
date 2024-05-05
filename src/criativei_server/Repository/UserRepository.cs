using criativei_server.Repository;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserRepository
{
    private readonly IMongoCollection<UserEntity> _users;

    public UserRepository(DatabaseSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);
        _users = database.GetCollection<UserEntity>(settings.CollectionName);
    }

    public async Task<List<UserEntity>> GetUsersAsync()
    {
        return await _users.Find(user => true).ToListAsync();
    }

    public async Task<UserEntity> GetUserAsync(string id)
    {
        return await _users.Find<UserEntity>(user => user.Id == id).FirstOrDefaultAsync();
    }

    public async Task<UserEntity> CreateUserAsync(UserEntity user)
    {
        await _users.InsertOneAsync(user);
        return user;
    }

    public async Task UpdateUserAsync(string id, UserEntity userIn)
    {
        await _users.ReplaceOneAsync(user => user.Id == id, userIn);
    }

    public async Task DeleteUserAsync(string id)
    {
        await _users.DeleteOneAsync(user => user.Id == id);
    }
}