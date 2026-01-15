var dto1 = new UserDto("John", "john@mail.com");

Console.WriteLine($"Hello {dto1.Name}");

// not possible, because there are no setters
// var dto2 = new UserDto
// {
//     Name = "Maria",
//     Email = "maria@mail.com"  
// };

// Console.WriteLine($"Hello {dto2.Name}");


public class UserDto
{
    public string Name { get; }

    public string Email { get; }

    // public UserDto()
    // {
    // }

    public UserDto(string name, string email)
    {
        Name = name;
        Email = email;
    }
}
