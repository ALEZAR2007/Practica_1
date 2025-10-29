using System;

public class User
{
    public int Id { get; set; }
    public string Name_1 { get; set; }
    public string Name_2 { get; set; }
    public string Email { get; set; }
    public void DisplayInfo()
    {
        Console.WriteLine($"Пользователь: {Name_1} {Name_2}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"ID: {Id}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        User user = new User();
        user.Id = 1;
        user.Name_1 = "Иван";
        user.Name_2 = "Петров";
        user.Email = "ivan@example.com";
        user.DisplayInfo();
    }
}