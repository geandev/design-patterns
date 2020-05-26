using Specification.Rules.Abstractions;

namespace Specification.Rules.User
{
    public class UserNameRule : CompositeRule<Models.User>
    {
        public override bool IsSatisfiedBy(Models.User model)
        {
            return !string.IsNullOrEmpty(model.UserName);
        }
    }
}
