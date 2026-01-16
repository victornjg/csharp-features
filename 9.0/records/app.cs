var dto1 = new UserDto1("John", "john@mail.com");

Console.WriteLine($"Hello {dto1.Name}");

var dto2 = new UserDto2("Maria", "maria@mail.com");

Console.WriteLine($"Hello {dto2.Name}");


public record UserDto1(string Name, string Email);

public record UserDto2(string Name)
{
    public string Email { get; init; } = string.Empty;

    public UserDto2(string name, string email) : this(name)
    {
        Email = email;
    }
}

