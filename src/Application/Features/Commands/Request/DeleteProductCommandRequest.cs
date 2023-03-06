using Application.Features.Commands.Response;
using MediatR;

namespace Application.Features.Commands.Request
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public int Id { get; set; }
    }
}
