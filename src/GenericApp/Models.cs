using System;

// Модель пользователя
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    
    public override string ToString()
    {
        return $"User: Id = {Id}, Name = {Name}, Age = {Age}";
    }
}

// Модель товара
public class Product
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    
    public override string ToString()
    {
        return $"Товар: {Title}, Цена: {Price} руб.";
    }
}