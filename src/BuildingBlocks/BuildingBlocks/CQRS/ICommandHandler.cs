using MediatR;

namespace BuildingBlocks.CQRS;

public interface ICommandHandler<in TCommand>
    : IRequestHandler<TCommand, Unit>
    where TCommand : ICommand<Unit>
{
    
}

public interface ICommandHandler<in TCommand, TResponse> 
    : IRequestHandler<TCommand, TResponse> 
    where TCommand : IRequest<TResponse>
    where TResponse : notnull
{
    
}