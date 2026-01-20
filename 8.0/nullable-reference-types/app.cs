#:property Nullable=enable
#:property WarningsAsErrors=CS8600,CS8601,CS8602,CS8603,CS8625

var user1 = new User(null, "john@mail.com", "999999999", null);

Console.WriteLine(user1.Name == null ? "user1.Name is null" : $"Hello {user1.Name}");

var user2 = new User("Maria", "john@mail.com", null, null);

string nonNullabe = null;
string? nullable = default;

Console.WriteLine(nonNullabe == null ? "nonNullabe is null" : $"nonNullabe -> {nonNullabe}");
Console.WriteLine(nullable == null ? "nullable is null" : $"nullable -> {nullable}");


public class User
{
    public string Name { get; set; }

    public string Email { get; set; }

    public string? PhoneNumber { get; set; }

    public Company? Company { get; set; }

    public User(string name, string email, string? phoneNumber, Company? company)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Company = company;
    }
}

public class Company
{
    public string Name { get; set; }

    public Company(string name)
    {
        Name = name;
    }
}