using MediatR;
using Microsoft.AspNetCore.Mvc;
using MWS.Application.UseCases.Clientes.CreateCliente;

namespace MWS.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateClienteResponse>> Create(CreateClienteRequest request, CancellationToken cancellationToken)
        {
            var validator = new CreateClienteValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
