using System;
using System.Collections.Generic;

// Ограничение: T должен быть классом (ссылочный тип)
public class Repository<T> where T : class
{
    private List<T> items = new List<T>();
    
    public void Add(T item)
    {
        items.Add(item);
    }
    
    public void Remove(T item)
    {
        items.Remove(item);
    }
    
    public T Get(int index)
    {
        if (index >= 0 && index < items.Count)
            return items[index];
        return null;
    }
    
    public void PrintAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
    
    public int Count => items.Count;
}