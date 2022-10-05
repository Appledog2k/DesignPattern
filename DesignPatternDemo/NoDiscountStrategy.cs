namespace DesignPatternDemo;
public class NoDiscountStrategy : IPromoteStrategy
{
    public double DoDiscount(double price)
    {
        return price;
    }
}