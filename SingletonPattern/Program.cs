var ex = Example.GetInstance;
internal class Example
{
    static Example()
    {
        ExampleInstance = new Example();
    }
    private static Example? ExampleInstance { get; set; }
    #region 1.Yöntem
    private Example()
    {
        Console.WriteLine($"{nameof(Example)} sınıfından nesne oluşturuldu.");
    }



    public static Example GetInstance =>
        //1.yöntem
        //get { return ExampleInstance ??= new Example(); }
        ExampleInstance;

    #endregion

    #region 2.Yöntem

   


    #endregion
}