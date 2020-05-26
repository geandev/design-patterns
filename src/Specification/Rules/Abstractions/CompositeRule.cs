using Specification.Rules.Conditionals;

namespace Specification.Rules.Abstractions
{
    public abstract class CompositeRule<TModel> : IRule<TModel>
    {
        public abstract bool IsSatisfiedBy(TModel model);

        public CompositeRule<TModel> And(IRule<TModel> andRule)
        {
            return new AndConditionalRule<TModel>(this, andRule);
        }

        public CompositeRule<TModel> AndNot(IRule<TModel> andRule)
        {
            return new AndNotConditionalRule<TModel>(this, andRule);
        }
    }
}
