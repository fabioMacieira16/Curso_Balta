using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Handle;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Controllers;

[ApiController]
[Route("v1/custumer")]
public class CustomerController : ControllerBase
{
    [HttpPost]
    [Route("")]
    public Task<CreateCustomerResponse> Create(
        [FromServices] IMediator mediator,
        [FromBody] CreateCostumerRequests command)
    {

        return mediator.Send(command);
    }
}