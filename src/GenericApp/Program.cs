// ========== РЕШЕНИЕ С GENERICS ==========
// Один универсальный класс для любого типа!
class Storage<T>
{
    private T value;
    
    public void SetValue(T val)
    {
        value = val;
    }
    
    public T GetValue()
    {
        return value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Работа с int
        Storage<int> intStorage = new Storage<int>();
        intStorage.SetValue(42);
        Console.WriteLine($"Int: {intStorage.GetValue()}");
        
        // Работа с string (тот же класс!)
        Storage<string> strStorage = new Storage<string>();
        strStorage.SetValue("Hello");
        Console.WriteLine($"String: {strStorage.GetValue()}");
        
        // Работа с double (легко добавить!)
        Storage<double> doubleStorage = new Storage<double>();
        doubleStorage.SetValue(3.14);
        Console.WriteLine($"Double: {doubleStorage.GetValue()}");
    }
}