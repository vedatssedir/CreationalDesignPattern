var tsk1 = Task.Run(() =>
{
    Example.GetInstance();
});
var tsk2 = Task.Run(() =>
{
    Example.GetInstance();
});
await Task.WhenAll(tsk1, tsk2);
internal class Example
{
    private Example()
    {
        Console.WriteLine($"{nameof(Example)} nesne oluşturuldu.");
    }
    private static Example? _example;
    private static readonly object Obj = new();
    public static Example? GetInstance()
    {
        lock (Obj)
        {
            _example ??= new Example();
        }
        return _example;
    }
    
}