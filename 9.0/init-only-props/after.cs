var dto1 = new UserDto("John", "john@mail.com");

Console.WriteLine($"Hello {dto1.Name}");

// now since we're using init-only props we can also use the object initilizer
var dto2 = new UserDto
{
    Name = "Maria",
    Email = "maria@mail.com"  
};

Console.WriteLine($"Hello {dto2.Name}");


public class UserDto
{
    public string Name { get; init; } = string.Empty;

    public string Email { get; init; } = string.Empty;

    public UserDto()
    {
    }

    public UserDto(string name, string email)
    {
        Name = name;
        Email = email;
    }
}
