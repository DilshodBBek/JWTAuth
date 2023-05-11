using System.ComponentModel.DataAnnotations;

namespace JWTAuth.Models;

public class Users
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public string[] Permission { get; set; }

    public static List<Users> AllUsers = new()
    {
        new Users { Id = 1, FullName = "John Doe", Username = "johndoe", Password = "password1", Email = "johndoe@example.com", Permission=new[] { "GetUser", "CreateUser"} },
        new Users { Id = 2, FullName = "Jane Smith", Username = "janesmith", Password = "password2", Email = "janesmith@example.com", Permission=new[] { "DeleteUser", "UpdateUser" } },
        new Users { Id = 3, FullName = "Michael Johnson", Username = "michaeljohnson", Password = "password3", Email = "michaeljohnson@example.com", Permission=new[] { "GetUser"} },
        new Users { Id = 4, FullName = "Emily Davis", Username = "emilydavis", Password = "password4", Email = "emilydavis@example.com", Permission=new[] { "GetUser", "UpdateUser" } },
        new Users { Id = 5, FullName = "David Brown", Username = "davidbrown", Password = "password5", Email = "davidbrown@example.com", Permission=new[] { "Saler", "User"} },
        new Users { Id = 6, FullName = "Emma Wilson", Username = "emmawilson", Password = "password6", Email = "emmawilson@example.com", Permission=new[] { "Admin", "Supervisor"} },
        new Users { Id = 7, FullName = "James Taylor", Username = "jamestaylor", Password = "password7", Email = "jamestaylor@example.com", Permission=new[] { "Admin", "Supervisor"} },
        new Users { Id = 8, FullName = "Olivia Johnson", Username = "oliviajohnson", Password = "password8", Email = "oliviajohnson@example.com", Permission=new[] { "Admin", "Supervisor"} },
        new Users { Id = 9, FullName = "Daniel Wilson", Username = "danielwilson", Password = "password9", Email = "danielwilson@example.com" },
        new Users { Id = 10, FullName = "Sophia Davis", Username = "sophiadavis", Password = "password10", Email = "sophiadavis@example.com" },
        new Users { Id = 11, FullName = "Liam Brown", Username = "liambrown", Password = "password11", Email = "liambrown@example.com" },
        new Users { Id = 12, FullName = "Mia Johnson", Username = "miajohnson", Password = "password12", Email = "miajohnson@example.com" },
        new Users { Id = 13, FullName = "Noah Wilson", Username = "noahwilson", Password = "password13", Email = "noahwilson@example.com" },
        new Users { Id = 14, FullName = "Ava Davis", Username = "avadavis", Password = "password14", Email = "avadavis@example.com" },
        new Users { Id = 15, FullName = "Ethan Smith", Username = "ethansmith", Password = "password15", Email = "ethansmith@example.com" },
        new Users { Id = 16, FullName = "Isabella Taylor", Username = "isabellataylor", Password = "password16", Email = "isabellataylor@example.com" },
        new Users { Id = 17, FullName = "Mason Johnson", Username = "masonjohnson", Password = "password17", Email = "masonjohnson@example.com" },
        new Users { Id = 18, FullName = "Sophia Davis", Username = "sophiadavis", Password = "password18", Email = "sophiadavis@example.com" },
        new Users { Id = 19, FullName = "Alexander Wilson", Username = "alexanderwilson", Password = "password19", Email = "alexanderwilson@example.com" },
        new Users { Id = 20, FullName = "Charlotte Brown", Username = "charlottebrown", Password = "password20", Email = "charlottebrown@example.com" }
    };
}
