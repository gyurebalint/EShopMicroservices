
namespace Basket.API.Basket.DeleteBasket;

public record DeleteBasketCommand(string UserName)
    :ICommand<DeleteBasketResult>;
public record DeleteBasketResult(bool IsSuccess);

public class DeleteBasketCommandValidator:AbstractValidator<DeleteBasketCommand>
{
    public DeleteBasketCommandValidator()
    {
        RuleFor(c => c.UserName).NotEmpty().WithMessage("Username is required");
    }
}
public class DeleteBasketCommandHandler
    : ICommandHandler<DeleteBasketCommand, DeleteBasketResult>
{
    public Task<DeleteBasketResult> Handle(DeleteBasketCommand command, CancellationToken cancellationToken)
    {
        //TODO: delete basket from databse and cache
        //session.Delete<Product(command.Id);

        return new DeleteBasketResult(true);
    }
}
