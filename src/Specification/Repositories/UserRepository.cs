using Specification.Models;
using Specification.Rules.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace Specification.Repositories
{
    public class UserRepository
    {
        private static IReadOnlyList<User> Users = new[]
        {
            new User("Gean", "1234556768", "gean.silvatest.com", false),
            new User("Railson", "1234556768", "gean.silvatest.com", true),
            new User("Ariano", "1234556768", "gean.silva@test.com", false),
            new User("Eduardo", "1234556768", "gean.silvatest.com", false),
            new User("Caio", "1234556768", "gean.silva@test.com", true),

        }.ToList();


        public IReadOnlyList<User> GetUsersByRule(IRule<User> userRule)
        {
            return Users.Where(userRule.IsSatisfiedBy).ToList();
        }
    }
}
