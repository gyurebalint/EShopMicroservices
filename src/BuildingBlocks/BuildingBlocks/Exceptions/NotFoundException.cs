namespace BuildingBlocks.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(string name, object key) : base($"Entitit \"{name}\" ({key}) was not found")
    {
    }
}
