using Core.Entities;

namespace Core.Utilities.Results;

public interface IDataResult<out T> : IResult
{
    public T Data { get; }
}
