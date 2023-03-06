using Application.Features.Queries.Response;
using MediatR;

namespace Application.Features.Queries.Request
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public int Id { get; set; }
    }
}
