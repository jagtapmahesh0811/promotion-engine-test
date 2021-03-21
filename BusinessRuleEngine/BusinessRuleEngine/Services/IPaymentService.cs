namespace BusinessRuleEngine.Services
{
    public interface IPaymentService
    {
        void DoPayment<T>(T item);
    }
}
