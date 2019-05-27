using StoreService.Models;
using System.Collections.Generic;

namespace StoreService.Repository
{
    public interface IUser
    {
        void Add(User user);

        IEnumerable<User> GetAll();

        User Find(long id);

        void remove(long id);

        void update(User user);
    }
}
