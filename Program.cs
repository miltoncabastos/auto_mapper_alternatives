using AutoMapperAlternatives;

// Simple Entity
var person = new Entity
{
    Id = 1,
    Name = "John Doe",
    Email = "john.doe@gmail.com"
};
Console.WriteLine($"Person: {person.Id} / {person.Name} / {person.Email}");

// Implicit Operator
EntityForImplicit entityForImplicitOperator = person;
Console.WriteLine($"PersonDto: {entityForImplicitOperator.Id} / {entityForImplicitOperator.Name} / {entityForImplicitOperator.Email}");

// Explicit Operator
EntityForExplicit entityForExplicitOperator = (EntityForExplicit)person;
Console.WriteLine($"PersonResponse: {entityForExplicitOperator.Id} / {entityForExplicitOperator.Name} / {entityForExplicitOperator.Email}");

// Extension Method
EntityForExtension entityForExtension = person.ToReadModel();
Console.WriteLine($"PersonReadModel: {entityForExtension.Id} / {entityForExtension.Name} / {entityForExtension.Email}");