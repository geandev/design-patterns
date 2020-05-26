namespace Specification.Rules.Abstractions
{
    public interface IRule<in TModel>
    {
        bool IsSatisfiedBy(TModel model);
    }
}
