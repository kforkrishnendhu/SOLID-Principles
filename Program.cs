using SOLID.D;
using SOLID.S;
using SOLID.O;

namespace SOLID;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //SRP example
        UserService service = new UserService();
        service.Register("example@abc.com", "uvwxyz");
        service.Login("example@abc.com", "uvwxyz");

        //OCP example
        AreaCalculator areaCalculator = new AreaCalculator();
        Circle circle = new Circle(3);
        Rectangle rectangle = new Rectangle(3, 4);
        double totArea= areaCalculator.TotalArea(new IArea[] {circle,rectangle});
        Console.WriteLine("Total Area: " + totArea);

        //DIP
        ILog objLog = new DatabaseLogger();
        var pdService = new ProductService(objLog);
        pdService.Log("Hello");
        //here we have used the dependancy injection to invert the dependancy of that classes.

    }
}

