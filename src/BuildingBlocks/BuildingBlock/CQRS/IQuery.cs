using MediatR;

namespace BuildingBlock.CQRS;

internal interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : notnull
{

}