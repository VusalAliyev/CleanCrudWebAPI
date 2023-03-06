using Application.Features.Commands.Request;
using Application.Features.Commands.Response;
using Infrastructure;
using MediatR;

namespace Application.Features.Handlers.CommandHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly AppDbContext _context;

        public UpdateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedProduct = _context.Products.FirstOrDefault(p => p.Id == request.Id);
            updatedProduct.Name = request.Name;
            updatedProduct.Price = request.Price;
            updatedProduct.Quantity = request.Quantity;

            _context.SaveChanges();

            return new UpdateProductCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
