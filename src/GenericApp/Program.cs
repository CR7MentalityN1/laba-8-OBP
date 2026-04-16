// ========== ПЛОХОЙ КОД (БЕЗ GENERICS) ==========
// Класс только для int
class IntStorage
{
    private int value;
    
    public void SetValue(int val)
    {
        value = val;
    }
    
    public int GetValue()
    {
        return value;
    }
}

// Класс только для string (дублирование кода!)
class StringStorage
{
    private string value;
    
    public void SetValue(string val)
    {
        value = val;
    }
    
    public string GetValue()
    {
        return value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Работа с int
        IntStorage intStorage = new IntStorage();
        intStorage.SetValue(42);
        Console.WriteLine($"Int: {intStorage.GetValue()}");
        
        // Работа с string
        StringStorage stringStorage = new StringStorage();
        stringStorage.SetValue("Hello");
        Console.WriteLine($"String: {stringStorage.GetValue()}");
    }
}