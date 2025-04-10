namespace AutoMapperAlternatives;

public static class PersonExtensions
{
    public static PersonReadModel ToReadModel(this Person person)
    {
        return new PersonReadModel
        {
            Id = person.Id,
            Name = person.Name,
            Email = person.Email
        };
    }
}