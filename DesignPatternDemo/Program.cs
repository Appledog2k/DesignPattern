using DesignPatternDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Start getting tickets!");
        var random = new Random();
        for (int i = 0; i < 5; i++)
        {
            var ticket = new Ticket();
            ticket.SetName("Ticket" + i);
            ticket.SetPrice(50 * i);
            GeneratorStrategy(random, ticket);

            var promotedPrice = ticket.GetPromotePrice();
            LogTicketDetail(ticket, promotedPrice);
        }
    }

    private static void LogTicketDetail(Ticket ticket, double promotedPrice)
    {
        Console.WriteLine("Promoted price of " + ticket.GetName() + " is " + promotedPrice);
    }

    private static void GeneratorStrategy(Random random, Ticket ticket)
    {
        var strategyIndex = random.Next(0, 2);
        switch (strategyIndex)
        {
            case 0:
                ticket.SetPromoteStrategy(new NoDiscountStrategy());
                break;
            case 1:
                ticket.SetPromoteStrategy(new QuarterDiscountStrategy());
                break;
            case 2:
                ticket.SetPromoteStrategy(new HalfDiscountStrategy());
                break;
        };
    }
}