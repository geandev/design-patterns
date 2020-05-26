using Specification.Rules.Abstractions;

namespace Specification.Rules.User
{
    public class UserArchivedRule : CompositeRule<Models.User>
    {
        public override bool IsSatisfiedBy(Models.User model)
        {
            return model?.Archived == true;
        }
    }
}
