using Specification.Models;
using Specification.Repositories;
using Specification.Rules.Abstractions;
using Specification.Rules.User;
using System.Linq;

namespace Specification
{
    class Program
    {
        static void Main()
        {
            var userTest = new User("GeanSilva", "123456", "gean@gmail.com", false);

            IRule<User> userRules = new UserNameRule()
                .And(new UserPasswordRule())
                .And(new UserEmailRule());


            var userRepository = new UserRepository();

            var queryUser = new UserEmailRule()
                .AndNot(new UserArchivedRule());

            userRepository
                .GetUsersByRule(queryUser)
                .ToList()
                .ForEach(user => {
                    System.Console.WriteLine("================");
                    System.Console.WriteLine($"UserName: {user.UserName}");
                    System.Console.WriteLine($"Email: {user.Email}");
                    System.Console.WriteLine($"Archived: {user.Archived}");
                    System.Console.WriteLine("================");
                });



        }
    }
}
