using Specification.Rules.Abstractions;

namespace Specification.Rules.Conditionals
{
    public class AndConditionalRule<TModel> : CompositeRule<TModel>
    {
        private readonly IRule<TModel> _leftRule;
        private readonly IRule<TModel> _rightRule;

        public AndConditionalRule(IRule<TModel> leftRule, IRule<TModel> rightRule)
        {
            _leftRule = leftRule;
            _rightRule = rightRule;
        }

        public override bool IsSatisfiedBy(TModel model)
        {
            return _leftRule.IsSatisfiedBy(model) && _rightRule.IsSatisfiedBy(model);
        }
    }
}
