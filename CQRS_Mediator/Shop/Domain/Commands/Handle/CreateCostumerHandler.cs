using Shop.Domain.Commands.Responses;
using Shop.Domain.Commands.Requests;
using MediatR;

namespace Shop.Domain.Commands.Handle;

public class CreateCostumerHandler : IRequestHandler<CreateCostumerRequests, CreateCustomerResponse>
{
    public Task<CreateCustomerResponse> Handle(CreateCostumerRequests request, CancellationToken cancellationToken)
    {

        var result = new CreateCustomerResponse
        {
            Id = Guid.NewGuid(),
            Name = "Fabio Macieira",
            Email = "FabioMacieira@100k.com.br",
            Date = DateTime.Now
        };

        return Task.FromResult(result);
    }
}