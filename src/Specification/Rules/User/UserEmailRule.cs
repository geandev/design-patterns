using Specification.Rules.Abstractions;

namespace Specification.Rules.User
{
    public class UserEmailRule : CompositeRule<Models.User>
    {
        public override bool IsSatisfiedBy(Models.User model)
        {
            return model?.Email?.Contains("@") == true;
        }
    }
}
