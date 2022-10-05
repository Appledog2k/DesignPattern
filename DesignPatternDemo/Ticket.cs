namespace DesignPatternDemo;
public class Ticket
{
    private IPromoteStrategy _promoteStrategy { get; set; }
    private double _price { get; set; }
    private string _name { get; set; }
    public void SetPromoteStrategy(IPromoteStrategy value)
    {
        _promoteStrategy = value;
    }
    public IPromoteStrategy GetPromoteStrategy()
    {
        return _promoteStrategy;
    }
    public void SetName(string value)
    {
        _name = value;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetPrice(double value)
    {
        _price = value;
    }
    public double GetPrice()
    {
        return _price;
    }
    public Ticket()
    {

    }
    public Ticket(IPromoteStrategy promoteStrategy)
    {
        _promoteStrategy = promoteStrategy;
    }
    public double GetPromotePrice()
    {
        return _promoteStrategy.DoDiscount(_price);
    }
}