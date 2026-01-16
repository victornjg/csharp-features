var dto1 = new UserDtoReadOnly("John", "john@mail.com");

Console.WriteLine($"Hello {dto1.Name}");

var dto2 = new UserDtoInit
{
    Name = "Maria",
    Email = "maria@mail.com"  
};

Console.WriteLine($"Hello {dto2.Name}");

var dto3 = new UserDtoInit("Gabriel", "gabriel@mail.com");

Console.WriteLine($"Hello {dto3.Name}");


public class UserDtoReadOnly
{
    public string Name { get; }

    public string Email { get; }

    public UserDtoReadOnly(string name, string email)
    {
        Name = name;
        Email = email;
    }
}

public class UserDtoInit
{
    public string Name { get; init; } = string.Empty;

    public string Email { get; init; } = string.Empty;

    public UserDtoInit()
    {
    }

    public UserDtoInit(string name, string email)
    {
        Name = name;
        Email = email;
    }
}
