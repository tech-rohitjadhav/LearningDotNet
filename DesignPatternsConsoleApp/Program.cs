using DesignPatternsConsoleApp.Creational.Singleton;
using DesignPatternsConsoleApp.Creational.FactoryMethod;
using DesignPatternsConsoleApp.Creational.AbstractFactory;
using DesignPatternsConsoleApp.Creational.Builder;
using DesignPatternsConsoleApp.Creational.Prototype;
using DesignPatternsConsoleApp.Structural.Adapter;
using DesignPatternsConsoleApp.Structural.Decorator;
using DesignPatternsConsoleApp.Behavioral.Observer;
using DesignPatternsConsoleApp.Behavioral.Strategy;

namespace DesignPatternsConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Design Patterns Demonstration ===\n");

        DemonstrateCreationalPatterns();
        DemonstrateStructuralPatterns();
        DemonstrateBehavioralPatterns();

        Console.WriteLine("\n=== All Design Patterns Demonstrated Successfully! ===");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void DemonstrateCreationalPatterns()
    {
        Console.WriteLine("🏗️  CREATIONAL PATTERNS\n");

        DemonstrateSingletonPattern();
        DemonstrateFactoryMethodPattern();
        DemonstrateAbstractFactoryPattern();
        DemonstrateBuilderPattern();
        DemonstratePrototypePattern();

        Console.WriteLine();
    }

    static void DemonstrateSingletonPattern()
    {
        Console.WriteLine("🔹 SINGLETON PATTERN");
        Console.WriteLine("Ensures a class has only one instance and provides global access to it\n");

        // Demonstrate thread-safe singleton
        var db1 = DatabaseConnection.GetInstance();
        var db2 = DatabaseConnection.GetInstance();
        
        Console.WriteLine($"Are both instances the same? {ReferenceEquals(db1, db2)}");
        Console.WriteLine($"Connection created at: {db1.CreatedAt:HH:mm:ss}");
        
        db1.ExecuteQuery("SELECT * FROM Users");
        db2.ExecuteQuery("SELECT * FROM Products");

        // Demonstrate Lazy<T> singleton
        var logger1 = Logger.Instance;
        var logger2 = Logger.Instance;
        
        Console.WriteLine($"Are both logger instances the same? {ReferenceEquals(logger1, logger2)}");
        
        logger1.Log("Application started");
        logger2.LogError("Something went wrong");
        logger1.Log("Application ended");

        Console.WriteLine();
    }

    static void DemonstrateFactoryMethodPattern()
    {
        Console.WriteLine("🔹 FACTORY METHOD PATTERN");
        Console.WriteLine("Creates objects without specifying their exact classes\n");

        VehicleFactory[] factories = {
            new CarFactory(),
            new MotorcycleFactory(),
            new TruckFactory()
        };

        foreach (var factory in factories)
        {
            factory.ManufactureVehicle();
            Console.WriteLine();
        }
    }

    static void DemonstrateAbstractFactoryPattern()
    {
        Console.WriteLine("🔹 ABSTRACT FACTORY PATTERN");
        Console.WriteLine("Creates families of related objects without specifying their concrete classes\n");

        IFurnitureFactory[] factories = {
            new ModernFurnitureFactory(),
            new VictorianFurnitureFactory()
        };

        foreach (var factory in factories)
        {
            Console.WriteLine($"Creating {factory.GetType().Name} furniture set:");
            
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();
            var table = factory.CreateTable();

            Console.WriteLine($"Chair: {chair.Name} ({chair.GetStyle()})");
            chair.Sit();
            
            Console.WriteLine($"Sofa: {sofa.Name} ({sofa.GetStyle()})");
            sofa.Relax();
            
            Console.WriteLine($"Table: {table.Name} ({table.GetStyle()})");
            table.PlaceItems();
            
            Console.WriteLine();
        }
    }

    static void DemonstrateBuilderPattern()
    {
        Console.WriteLine("🔹 BUILDER PATTERN");
        Console.WriteLine("Constructs complex objects step by step\n");

        var builder = new ComputerBuilder();
        var director = new ComputerDirector(builder);

        var gamingPC = director.BuildGamingPC();
        Console.WriteLine();
        gamingPC.DisplaySpecifications();
        Console.WriteLine();

        var officePC = director.BuildOfficePC();
        Console.WriteLine();
        officePC.DisplaySpecifications();
        Console.WriteLine();
    }

    static void DemonstratePrototypePattern()
    {
        Console.WriteLine("🔹 PROTOTYPE PATTERN");
        Console.WriteLine("Creates objects by cloning existing instances\n");

        var registry = new EmployeeRegistry();

        // Create and register prototypes
        var developerPrototype = new Employee
        {
            Name = "John Developer",
            Department = "IT",
            Position = "Software Developer",
            Salary = 75000,
            HireDate = DateTime.Now.AddYears(-2),
            Skills = new List<string> { "C#", "JavaScript", "SQL" }
        };

        var managerPrototype = new Employee
        {
            Name = "Jane Manager",
            Department = "IT",
            Position = "Development Manager",
            Salary = 95000,
            HireDate = DateTime.Now.AddYears(-5),
            Skills = new List<string> { "Leadership", "Project Management", "C#" }
        };

        registry.RegisterPrototype("Developer", developerPrototype);
        registry.RegisterPrototype("Manager", managerPrototype);

        // Create new employees from prototypes
        var newDeveloper = registry.CreateEmployee("Developer");
        newDeveloper.Name = "Alice Developer";
        newDeveloper.HireDate = DateTime.Now;

        var newManager = registry.CreateEmployee("Manager");
        newManager.Name = "Bob Manager";
        newManager.HireDate = DateTime.Now;

        Console.WriteLine("New employees created from prototypes:");
        newDeveloper.DisplayInfo();
        newManager.DisplayInfo();
    }

    static void DemonstrateStructuralPatterns()
    {
        Console.WriteLine("🏗️  STRUCTURAL PATTERNS\n");

        DemonstrateAdapterPattern();
        DemonstrateDecoratorPattern();

        Console.WriteLine();
    }

    static void DemonstrateAdapterPattern()
    {
        Console.WriteLine("🔹 ADAPTER PATTERN");
        Console.WriteLine("Allows incompatible interfaces to work together\n");

        var legacyPrinter = new LegacyPrinter();
        var adapter = new PrinterAdapter(legacyPrinter);

        // Using the new interface with legacy implementation
        adapter.Print("Hello World", "text");
        adapter.Print("image.jpg", "image");
        adapter.Scan("document.pdf");
        adapter.Copy("report.docx", 3);

        Console.WriteLine();
    }

    static void DemonstrateDecoratorPattern()
    {
        Console.WriteLine("🔹 DECORATOR PATTERN");
        Console.WriteLine("Adds behavior to objects dynamically\n");

        // Start with simple coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"Order: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost():F2}");
        Console.WriteLine();

        // Add milk
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"Order: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost():F2}");
        Console.WriteLine();

        // Add sugar
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"Order: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost():F2}");
        Console.WriteLine();

        // Add whipped cream
        coffee = new WhippedCreamDecorator(coffee);
        Console.WriteLine($"Order: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost():F2}");
        Console.WriteLine();
    }

    static void DemonstrateBehavioralPatterns()
    {
        Console.WriteLine("🎭 BEHAVIORAL PATTERNS\n");

        DemonstrateObserverPattern();
        DemonstrateStrategyPattern();

        Console.WriteLine();
    }

    static void DemonstrateObserverPattern()
    {
        Console.WriteLine("🔹 OBSERVER PATTERN");
        Console.WriteLine("Defines a one-to-many dependency between objects\n");

        var newsAgency = new NewsAgency();
        
        var cnn = new NewsChannel("CNN");
        var bbc = new NewsChannel("BBC");
        var fox = new NewsChannel("Fox News");

        newsAgency.Attach(cnn);
        newsAgency.Attach(bbc);
        newsAgency.Attach(fox);

        newsAgency.PublishNews("Breaking: New technology breakthrough announced!");
        Console.WriteLine();

        newsAgency.Detach(fox);
        newsAgency.PublishNews("Update: Market shows positive response to the news");
        Console.WriteLine();
    }

    static void DemonstrateStrategyPattern()
    {
        Console.WriteLine("🔹 STRATEGY PATTERN");
        Console.WriteLine("Defines a family of algorithms and makes them interchangeable\n");

        var processor = new PaymentProcessor(new CreditCardPayment());
        
        Console.WriteLine($"Current payment method: {processor.GetCurrentPaymentMethod()}");
        processor.ProcessPayment(100.00m);
        Console.WriteLine();

        processor.SetPaymentStrategy(new PayPalPayment());
        processor.ProcessPayment(250.50m);
        Console.WriteLine();

        processor.SetPaymentStrategy(new BankTransferPayment());
        processor.ProcessPayment(1000.00m);
        Console.WriteLine();
    }
}
