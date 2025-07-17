using SOLID.D;

namespace SOLID;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ILog objLog = new DatabaseLogger();
        var pdService = new ProductService(objLog);
        pdService.Log("Hello");
        //here we have used the dependancy injection to invert the dependancy of that classes.

    }
}

