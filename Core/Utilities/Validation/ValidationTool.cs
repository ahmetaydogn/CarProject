using Core.Entities;
using FluentValidation;

namespace Core.Utilities.Validation;

public static class ValidationTool<TEntity> where TEntity : class, IEntity, new()
{
    public static void Validate(IValidator<TEntity> validator, TEntity entity)
    {
        var result = validator.Validate(entity);
        if (!result.IsValid)
        {
            throw new ValidationException(result.Errors);
        }
    }
}
