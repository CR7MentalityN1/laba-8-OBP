using System;

class Program
{
    static void Main(string[] args)
    {
        // ========== Тестирование Repository ==========
        Console.WriteLine("=== Тестирование Repository<T> ===\n");
        
        // Репозиторий для пользователей
        Repository<User> userRepo = new Repository<User>();
        userRepo.Add(new User { Name = "Егор", Age = 20 });
        userRepo.Add(new User { Name = "Кирилл", Age = 21 });
        userRepo.Add(new User { Name = "Анна", Age = 19 });
        
        Console.WriteLine("Пользователи:");
        userRepo.PrintAll();
        
        // Репозиторий для товаров
        Repository<Product> productRepo = new Repository<Product>();
        productRepo.Add(new Product { Title = "Ноутбук", Price = 50000 });
        productRepo.Add(new Product { Title = "Телефон", Price = 40000 });
        productRepo.Add(new Product { Title = "Наушники", Price = 5000 });
        
        Console.WriteLine("\nТовары:");
        productRepo.PrintAll();
        
        // Демонстрация остальных методов
        Console.WriteLine($"\nКоличество пользователей: {userRepo.Count}");
        Console.WriteLine($"Количество товаров: {productRepo.Count}");
        
        User firstUser = userRepo.Get(0);
        Console.WriteLine($"\nПервый пользователь: {firstUser}");
    }
}