namespace BusinessRuleEngine.RuleEngine
{
    public interface IPaymentRule
    {
        void DoPaymentWithRuleEngine<T>(T item);
    }
}
