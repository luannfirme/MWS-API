using MediatR;
using Microsoft.AspNetCore.Mvc;
using MWS.Application.UseCases.Clientes.CreateCliente;
using MWS.Application.UseCases.Clientes.DeleteCliente;
using MWS.Application.UseCases.Clientes.GetAllCliente;
using MWS.Application.UseCases.Clientes.UpdateCliente;

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
            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllClienteResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllClienteRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateClienteResponse>> Update(Guid id, UpdateClienteRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
                return BadRequest();

            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UpdateClienteResponse>> Delete(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null)
                return BadRequest();

            var request = new DeleteClienteRequest(id.Value);

            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);
        }
    }
}
