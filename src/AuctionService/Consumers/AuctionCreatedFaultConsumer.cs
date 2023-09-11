using Contracts;
using MassTransit;

namespace AuctionService.Consumers;

public class AuctionCreatedFaultConsumer : IConsumer<Fault<AuctionCreated>>
{
    public async Task Consume(ConsumeContext<Fault<AuctionCreated>> context)
    {
        Console.WriteLine("--> Consuming faulty creation");
        var exception = context.Message.Exceptions.First();
        if(exception.ExceptionType == typeof(ArgumentException).FullName)
        {
            Console.WriteLine($"--> ArgumentException: {exception.Message}");
            context.Message.Message.Model = "FooBar";
            await context.Publish<AuctionCreated>(context.Message.Message);
        }
        else
        {
            Console.WriteLine($"--> Unknown exception: {exception.Message}");
        }
    }
}
