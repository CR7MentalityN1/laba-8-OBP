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
        // ========== Тестирование Swap и PrintArray ==========
        int x = 10, y = 20;
        Console.WriteLine($"До обмена: x = {x}, y = {y}");
        Helper.Swap(ref x, ref y);
        Console.WriteLine($"После обмена: x = {x}, y = {y}");
        
        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"\nДо обмена: str1 = {str1}, str2 = {str2}");
        Helper.Swap(ref str1, ref str2);
        Console.WriteLine($"После обмена: str1 = {str1}, str2 = {str2}");
        
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.Write("\nМассив чисел: ");
        Helper.PrintArray(numbers);
        
        string[] words = { "C#", "Generics", "ООП" };
        Console.Write("Массив строк: ");
        Helper.PrintArray(words);
        
        // ========== Тестирование Calculator (Constraints) ==========
        Console.WriteLine("\n=== Тестирование Calculator ===");
        
        // Поиск максимума
        int maxInt = Calculator.Max(15, 30);
        Console.WriteLine($"Max из 15 и 30: {maxInt}");
        
        string maxStr = Calculator.Max("Apple", "Banana");
        Console.WriteLine($"Max из Apple и Banana: {maxStr}");
        
        // Поиск минимума
        double minDouble = Calculator.Min(3.14, 2.71);
        Console.WriteLine($"Min из 3.14 и 2.71: {minDouble}");
        
        int minInt = Calculator.Min(100, 50);
        Console.WriteLine($"Min из 100 и 50: {minInt}");
    }
}