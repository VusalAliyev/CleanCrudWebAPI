using Application.Features.Commands.Request;
using Application.Features.Commands.Response;
using Infrastructure;
using MediatR;

namespace Application.Features.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        private readonly AppDbContext _context;

        public CreateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new()
            {
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity
            });
            _context.SaveChanges();
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                Name = request.Name
            };
        }
    }
}
