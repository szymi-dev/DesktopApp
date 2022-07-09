using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        Task<IReadOnlyList<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}