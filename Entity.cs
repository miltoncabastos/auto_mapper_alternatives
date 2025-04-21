namespace AutoMapperAlternatives;

public class Entity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    // Implicit Operator
    public static implicit operator EntityForImplicit(Entity entity)
    {
        return new EntityForImplicit
        {
            Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email
        };
    }

    // Explicit Operator
    public static explicit operator EntityForExplicit(Entity entity)
    {
        return new EntityForExplicit
        {
            Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email
        };
    }
}