namespace Core.Utilities.Results;

public interface IResult
{
    // Since the values will only be received in the constructor structure, the get blocks are sufficient.
    public bool IsSuccess { get; }
    public string Message { get; }
}
