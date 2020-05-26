using Specification.Rules.Abstractions;

namespace Specification.Rules.User
{
    public class UserPasswordRule : CompositeRule<Models.User>
    {
        public override bool IsSatisfiedBy(Models.User model)
        {
            return model?.Password?.Length > 8;
        }
    }
}
