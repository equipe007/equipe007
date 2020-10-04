using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cotrack_api.Configuration;
using cotrack_api.Interfaces;
using cotrack_api.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace cotrack_api.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoDatabase _database = null;

        public UserService(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<User> Usuarios
        {
            get
            {
                return _database.GetCollection<User>("Usuarios");
            }
        }

        public User Find(string id)
        {
            return Usuarios.Find<User>(user => user.Id == id).FirstOrDefault();
        }

        public List<User> FindAll()
        {
            return Usuarios.Find(listUser => true).ToList();
        }

        public User Save(User user)
        {
            Usuarios.InsertOne(user);
            return user;
        }

        public void Update(string id, User userIn)
        {
            Usuarios.ReplaceOne(user => user.Id == id, userIn);
        }

        public void Remove(string id)
        {
            Usuarios.DeleteOne(user => user.Id == id);
        }


    }
}
