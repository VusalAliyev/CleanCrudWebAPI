using Application.Features.Queries.Request;
using Application.Features.Queries.Response;
using Infrastructure;
using MediatR;

namespace Application.Features.Handlers.QueryHandlers
{
    public class GetByIdProductHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        private readonly AppDbContext _context;

        public GetByIdProductHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == request.Id);
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }
    }
}
