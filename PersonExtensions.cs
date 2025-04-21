namespace AutoMapperAlternatives;

public static class PersonExtensions
{
    public static EntityForExtension ToReadModel(this Entity entity)
    {
        return new EntityForExtension
        {
            Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email
        };
    }
}