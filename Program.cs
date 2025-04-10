using AutoMapperAlternatives;

Console.WriteLine("Hello, World!");

var person = new Person
{
    Id = 1,
    Name = "John Doe",
    Email = "john.doe@gmail.com"
};

PersonDto personDto = person;
PersonResponse personResponse = (PersonResponse)person;
PersonReadModel personReadModel = person.ToReadModel();

Console.WriteLine($"Person: {person.Id} / {person.Name} / {person.Email}");
Console.WriteLine($"PersonDto: {personDto.Id} / {personDto.Name} / {personDto.Email}");
Console.WriteLine($"PersonResponse: {personResponse.Id} / {personResponse.Name} / {personResponse.Email}");
Console.WriteLine($"PersonReadModel: {personReadModel.Id} / {personReadModel.Name} / {personReadModel.Email}");