namespace AutoMapperAlternatives;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public static implicit operator PersonDto(Person person)
    {
        return new PersonDto
        {
            Id = person.Id,
            Name = person.Name,
            Email = person.Email
        };
    }

    public static explicit operator PersonResponse(Person person)
    {
        return new PersonResponse
        {
            Id = person.Id,
            Name = person.Name,
            Email = person.Email
        };
    }
}