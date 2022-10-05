namespace DesignPatternDemo;
public class Ticket
{
    private IPromoteStrategy _promoteStrategy { get; set; }
    private double _price { get; set; }
    private string _name { get; set; }
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