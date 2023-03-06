using Application.Features.Commands.Request;
using Application.Features.Commands.Response;
using Infrastructure;
using MediatR;

namespace Application.Features.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        private readonly AppDbContext _context;

        public DeleteProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedProduct = _context.Products.FirstOrDefault(p => p.Id == request.Id);

            _context.Products.Remove(deletedProduct);
            _context.SaveChanges();
            return new DeleteProductCommandResponse
            {
                IsSuccess = true,
            };
        }
    }
}
