using System.Collections.Generic;
using System.Linq;
using StoreService.Context;
using StoreService.Models;

namespace StoreService.Repository
{
    public class UserRepository : IUser
    {
        private readonly UsersDbContext _ctx;

        public UserRepository(UsersDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(User user)
        {
            _ctx.Users.Add(user);
            _ctx.SaveChanges();
        }

        public User Find(long id)
        {
            return _ctx.Users.FirstOrDefault(u => u.id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _ctx.Users.ToList();
        }

        public void remove(long id)
        {
            var User = _ctx.Users.FirstOrDefault(u => u.id == id);


            if (!User.Equals(null))
            {
                _ctx.Users.Remove(User);
                _ctx.SaveChanges();
            }
        }

        public void update(User user)
        {
            _ctx.Users.Update(user);
            _ctx.SaveChanges();
        }
    }
}
