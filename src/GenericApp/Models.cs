using System;

// Модель пользователя
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public override string ToString()
    {
        return $"Пользователь: {Name}, Возраст: {Age}";
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