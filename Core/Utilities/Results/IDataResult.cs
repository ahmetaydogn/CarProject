using Core.Entities;

namespace Core.Utilities.Results;

public interface IDataResult<out T> : IEntity
{
    public T Data { get; }
}
