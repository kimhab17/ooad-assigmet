using System;

namespace saleAndBillingSystem
{
    public interface IDiscountStrategy
    {
        decimal CalculateDiscount(decimal totalAmount);
    }

    public class NoDiscountStrategy : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return 0; // No discount
        }
    }

    public class TenPercentDiscountStrategy : IDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * 0.10m; // 10% discount
        }
    }
}
