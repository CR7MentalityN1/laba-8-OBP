using System;

class Storage<T>
{
    private T value;
    public void SetValue(T val) { value = val; }
    public T GetValue() { return value; }
}

class Program
{
    static void Main(string[] args)
    {
        // Тестируем Swap
        int x = 10, y = 20;
        Console.WriteLine($"До обмена: x = {x}, y = {y}");
        Helper.Swap(ref x, ref y);
        Console.WriteLine($"После обмена: x = {x}, y = {y}");
        
        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"\nДо обмена: str1 = {str1}, str2 = {str2}");
        Helper.Swap(ref str1, ref str2);
        Console.WriteLine($"После обмена: str1 = {str1}, str2 = {str2}");
        
        // Тестируем PrintArray
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.Write("\nМассив чисел: ");
        Helper.PrintArray(numbers);
        
        string[] words = { "C#", "Generics", "ООП" };
        Console.Write("Массив строк: ");
        Helper.PrintArray(words);
    }
}