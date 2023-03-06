using Application.Features.Commands.Request;
using Application.Features.Commands.Response;
using Application.Features.Queries.Request;
using Application.Features.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProductQueryRequest requestModel)
        {
            List<GetAllProductQueryResponse> products = await _mediator.Send(requestModel);
            return Ok(products);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdProductQueryRequest requestModel)
        {
            GetByIdProductQueryResponse product = await _mediator.Send(requestModel);
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest requestModel)
        {
            CreateProductCommandResponse product = await _mediator.Send(requestModel);
            return Ok(product);
        }
        [HttpDelete("{Id}")]
        /* [Route("Delete")]*/
        public async Task<IActionResult> Delete([FromRoute] DeleteProductCommandRequest requestModel)
        {
            DeleteProductCommandResponse product = await _mediator.Send(requestModel);
            return Ok(product);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromQuery] UpdateProductCommandRequest requestModel)
        {
            UpdateProductCommandResponse product = await _mediator.Send(requestModel);
            return Ok(product);
        }
    }
}
