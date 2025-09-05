using SolidPrinciplesConsoleApp.SingleResponsibility;
using SolidPrinciplesConsoleApp.OpenClosed;
using SolidPrinciplesConsoleApp.LiskovSubstitution;
using SolidPrinciplesConsoleApp.InterfaceSegregation;
using SolidPrinciplesConsoleApp.DependencyInversion;

namespace SolidPrinciplesConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SOLID Principles Demonstration ===\n");

        DemonstrateSingleResponsibilityPrinciple();
        DemonstrateOpenClosedPrinciple();
        DemonstrateLiskovSubstitutionPrinciple();
        DemonstrateInterfaceSegregationPrinciple();
        DemonstrateDependencyInversionPrinciple();

        Console.WriteLine("\n=== All SOLID Principles Demonstrated Successfully! ===");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void DemonstrateSingleResponsibilityPrinciple()
    {
        Console.WriteLine("🔹 SINGLE RESPONSIBILITY PRINCIPLE");
        Console.WriteLine("Each class has only one reason to change\n");

        // Create dependencies
        var userRepository = new UserRepository();
        var emailService = new EmailService();
        var userService = new UserService(userRepository, emailService);

        // Demonstrate SRP
        userService.RegisterUser("John Doe", "john.doe@email.com");
        userService.RegisterUser("Jane Smith", "jane.smith@email.com");

        Console.WriteLine();
    }

    static void DemonstrateOpenClosedPrinciple()
    {
        Console.WriteLine("🔹 OPEN/CLOSED PRINCIPLE");
        Console.WriteLine("Open for extension, closed for modification\n");

        var calculator = new AreaCalculator();
        var shapes = new List<IShape>
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 4)
        };

        Console.WriteLine("Calculating areas of different shapes:");
        var totalArea = calculator.CalculateTotalArea(shapes);
        Console.WriteLine($"Total area: {totalArea:F2} square units\n");
    }

    static void DemonstrateLiskovSubstitutionPrinciple()
    {
        Console.WriteLine("🔹 LISKOV SUBSTITUTION PRINCIPLE");
        Console.WriteLine("Objects of a superclass should be replaceable with objects of a subclass\n");

        var zoo = new BirdZoo();
        
        // Add different types of birds
        zoo.AddBird(new Eagle("Thunder"));
        zoo.AddBird(new Penguin("Waddle"));
        zoo.AddBird(new Duck("Quackers"));

        // Demonstrate LSP - all birds can be treated uniformly
        zoo.FeedAllBirds();
        zoo.LetFlyableBirdsFly();
        zoo.LetSwimmableBirdsSwim();
        zoo.PutAllBirdsToSleep();

        Console.WriteLine();
    }

    static void DemonstrateInterfaceSegregationPrinciple()
    {
        Console.WriteLine("🔹 INTERFACE SEGREGATION PRINCIPLE");
        Console.WriteLine("Clients should not be forced to depend on interfaces they don't use\n");

        var workplace = new Workplace();
        
        // Add different types of workers
        workplace.AddWorker(new HumanWorker("Alice"));
        workplace.AddWorker(new RobotWorker("Robo-1"));
        workplace.AddManager(new Manager("Bob"));

        // Demonstrate ISP - each worker type only implements what it needs
        workplace.StartWorkDay();
        workplace.AssignTasks();
        workplace.LunchBreak();
        workplace.EndWorkDay();

        Console.WriteLine();
    }

    static void DemonstrateDependencyInversionPrinciple()
    {
        Console.WriteLine("🔹 DEPENDENCY INVERSION PRINCIPLE");
        Console.WriteLine("Depend on abstractions, not concretions\n");

        // Create concrete implementations
        var orderRepository = new InMemoryOrderRepository();
        var emailNotification = new EmailNotificationService();
        var consoleLogger = new ConsoleLogger();

        // Inject dependencies into high-level module
        var orderService = new OrderService(orderRepository, emailNotification, consoleLogger);

        // Demonstrate DIP - OrderService depends on abstractions
        orderService.CreateOrder("Charlie Brown", "Laptop", 999.99m, "charlie@email.com");
        orderService.UpdateOrderStatus(1, OrderStatus.Shipped);
        orderService.GetOrderDetails(1);

        Console.WriteLine("\n--- Switching to different implementations ---");

        // Demonstrate flexibility - can easily swap implementations
        var smsNotification = new SmsNotificationService();
        var fileLogger = new FileLogger();
        var flexibleOrderService = new OrderService(orderRepository, smsNotification, fileLogger);

        flexibleOrderService.CreateOrder("Diana Prince", "Smartphone", 699.99m, "diana@email.com");
        flexibleOrderService.UpdateOrderStatus(2, OrderStatus.Delivered);
        flexibleOrderService.GetOrderDetails(2);

        Console.WriteLine();
    }
}
