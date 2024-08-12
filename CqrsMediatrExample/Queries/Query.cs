using CqrsMediatrExample.Data_Store;
using CqrsMediatrExample.Models;
using MediatR;
using static CqrsMediatrExample.Queries.Query;

namespace CqrsMediatrExample.Queries
{
    public class Query
    {
        public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
        public record GetProductByIdQuery(int Id) : IRequest<Product>;
    }
}
