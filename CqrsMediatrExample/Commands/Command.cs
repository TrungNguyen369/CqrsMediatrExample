using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Command
{
    public class Command
    {
        public record AddProductCommand(Product Product) : IRequest<Product>;
    }
}
