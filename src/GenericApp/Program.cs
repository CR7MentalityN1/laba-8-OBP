using System;
using ResultLab;

class Program
{
    static void Main(string[] args)
    {
        // ========== Тестирование Repository ==========
        Console.WriteLine("=== Тестирование Repository<T> ===\n");
        
        Repository<User> userRepo = new Repository<User>();
        userRepo.Add(new User { Name = "Егор", Age = 20 });
        userRepo.Add(new User { Name = "Кирилл", Age = 21 });
        
        Console.WriteLine("Пользователи:");
        userRepo.PrintAll();
        
        Repository<Product> productRepo = new Repository<Product>();
        productRepo.Add(new Product { Title = "Ноутбук", Price = 50000 });
        productRepo.Add(new Product { Title = "Телефон", Price = 40000 });
        
        Console.WriteLine("\nТовары:");
        productRepo.PrintAll();
        
        // ========== Тестирование Result<T> ==========
        Console.WriteLine("\n=== Тестирование Result<T> ===\n");
        
        // Успешный случай
        var successResult = GetUser(1);
        if (successResult.IsSuccess)
        {
            Console.WriteLine("Операция выполнена успешно.");
            Console.WriteLine(successResult.Value);
        }
        else
        {
            Console.WriteLine("Произошла ошибка:");
            Console.WriteLine(successResult.Error);
        }
        
        // Ошибочный случай (неверный ID)
        var errorResult = GetUser(-5);
        if (errorResult.IsSuccess)
        {
            Console.WriteLine("\nОперация выполнена успешно.");
            Console.WriteLine(errorResult.Value);
        }
        else
        {
            Console.WriteLine("\nПроизошла ошибка:");
            Console.WriteLine(errorResult.Error);
        }
        
        // Ошибочный случай (пользователь не найден)
        var notFoundResult = GetUser(999);
        if (notFoundResult.IsSuccess)
        {
            Console.WriteLine("\nОперация выполнена успешно.");
            Console.WriteLine(notFoundResult.Value);
        }
        else
        {
            Console.WriteLine("\nПроизошла ошибка:");
            Console.WriteLine(notFoundResult.Error);
        }
    }
    
    // Метод, возвращающий Result<User>
    static Result<User> GetUser(int id)
    {
        // Проверка на корректность ID
        if (id <= 0)
        {
            return Result<User>.Failure("Идентификатор пользователя должен быть положительным.");
        }
        
        // Имитация поиска пользователя в базе данных
        var user = FindUserInDatabase(id);
        
        if (user == null)
        {
            return Result<User>.Failure($"Пользователь с ID = {id} не найден.");
        }
        
        return Result<User>.Success(user);
    }
    
    // Имитация базы данных пользователей
    static User FindUserInDatabase(int id)
    {
        var users = new[]
        {
            new User { Id = 1, Name = "Богдан", Age = 20 },
            new User { Id = 2, Name = "Анна", Age = 19 },
            new User { Id = 3, Name = "Кирилл", Age = 21 }
        };
        
        foreach (var user in users)
        {
            if (user.Id == id)
                return user;
        }
        return null;
    }
}