using DesignPatternsConsoleApp.Creational.Singleton;
using DesignPatternsConsoleApp.Creational.FactoryMethod;
using DesignPatternsConsoleApp.Creational.AbstractFactory;
using DesignPatternsConsoleApp.Creational.Builder;
using DesignPatternsConsoleApp.Creational.Prototype;
using DesignPatternsConsoleApp.Structural.Adapter;
using DesignPatternsConsoleApp.Structural.Decorator;
using DesignPatternsConsoleApp.Structural.Bridge;
using DesignPatternsConsoleApp.Structural.Composite;
using DesignPatternsConsoleApp.Structural.Facade;
using DesignPatternsConsoleApp.Structural.Proxy;
using DesignPatternsConsoleApp.Behavioral.Observer;
using DesignPatternsConsoleApp.Behavioral.Strategy;
using DesignPatternsConsoleApp.Behavioral.Command;
using DesignPatternsConsoleApp.Behavioral.State;
using DesignPatternsConsoleApp.Behavioral.TemplateMethod;
using DesignPatternsConsoleApp.Behavioral.ChainOfResponsibility;
using DesignPatternsConsoleApp.Behavioral.Mediator;
using DesignPatternsConsoleApp.Behavioral.Memento;
using DesignPatternsConsoleApp.Behavioral.Visitor;
using DesignPatternsConsoleApp.Behavioral.Iterator;
using DesignPatternsConsoleApp.Behavioral.Interpreter;
using DesignPatternsConsoleApp.Structural.Flyweight;

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
        DemonstrateBridgePattern();
        DemonstrateCompositePattern();
        DemonstrateFacadePattern();
        DemonstrateProxyPattern();
        DemonstrateFlyweightPattern();

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
        DemonstrateCommandPattern();
        DemonstrateStatePattern();
        DemonstrateTemplateMethodPattern();
        DemonstrateChainOfResponsibilityPattern();
        DemonstrateMediatorPattern();
        DemonstrateMementoPattern();
        DemonstrateVisitorPattern();
        DemonstrateIteratorPattern();
        DemonstrateInterpreterPattern();

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

    static void DemonstrateBridgePattern()
    {
        Console.WriteLine("🔹 BRIDGE PATTERN");
        Console.WriteLine("Separates abstraction from implementation\n");

        IRenderer vectorRenderer = new VectorRenderer();
        IRenderer rasterRenderer = new RasterRenderer();

        Shape[] shapes = {
            new Circle(vectorRenderer, 5.0f),
            new Circle(rasterRenderer, 5.0f),
            new Square(vectorRenderer, 4.0f),
            new Square(rasterRenderer, 4.0f)
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
        Console.WriteLine();
    }

    static void DemonstrateCompositePattern()
    {
        Console.WriteLine("🔹 COMPOSITE PATTERN");
        Console.WriteLine("Composes objects into tree structures\n");

        var root = new Structural.Composite.Directory("Root");
        var documents = new Structural.Composite.Directory("Documents");
        var images = new Structural.Composite.Directory("Images");
        var downloads = new Structural.Composite.Directory("Downloads");

        documents.Add(new Structural.Composite.File("report.docx", 1024));
        documents.Add(new Structural.Composite.File("presentation.pptx", 2048));

        images.Add(new Structural.Composite.File("photo1.jpg", 512));
        images.Add(new Structural.Composite.File("photo2.png", 768));

        downloads.Add(new Structural.Composite.File("software.exe", 5120));
        downloads.Add(new Structural.Composite.File("document.pdf", 256));

        root.Add(documents);
        root.Add(images);
        root.Add(downloads);

        root.Display();
        Console.WriteLine();
    }

    static void DemonstrateFacadePattern()
    {
        Console.WriteLine("🔹 FACADE PATTERN");
        Console.WriteLine("Provides a simplified interface to a complex subsystem\n");

        var computer = new ComputerFacade();
        
        computer.StartComputer();
        computer.RunApplication();
        computer.ShutdownComputer();
    }

    static void DemonstrateProxyPattern()
    {
        Console.WriteLine("🔹 PROXY PATTERN");
        Console.WriteLine("Provides a placeholder for another object\n");

        Console.WriteLine("Creating proxy for image1.jpg...");
        var imageProxy = new ImageProxy("image1.jpg");
        
        Console.WriteLine("First display (will load from disk):");
        imageProxy.Display();
        
        Console.WriteLine("Second display (will use cached version):");
        imageProxy.Display();
        Console.WriteLine();
    }

    static void DemonstrateCommandPattern()
    {
        Console.WriteLine("🔹 COMMAND PATTERN");
        Console.WriteLine("Encapsulates a request as an object\n");

        var light = new Light();
        var lightOnCommand = new LightOnCommand(light);
        var lightOffCommand = new LightOffCommand(light);
        var remote = new RemoteControl();

        remote.SetCommand(lightOnCommand);
        remote.PressButton();

        remote.SetCommand(lightOffCommand);
        remote.PressButton();

        remote.PressUndo();
        Console.WriteLine();
    }

    static void DemonstrateStatePattern()
    {
        Console.WriteLine("🔹 STATE PATTERN");
        Console.WriteLine("Allows an object to alter its behavior when its internal state changes\n");

        var vendingMachine = new VendingMachine();

        vendingMachine.DisplayStatus();
        vendingMachine.InsertMoney(2.00m);
        vendingMachine.DisplayStatus();
        
        vendingMachine.SelectProduct("Coke");
        vendingMachine.DisplayStatus();
        
        vendingMachine.DispenseProduct();
        vendingMachine.DisplayStatus();
        Console.WriteLine();
    }

    static void DemonstrateTemplateMethodPattern()
    {
        Console.WriteLine("🔹 TEMPLATE METHOD PATTERN");
        Console.WriteLine("Defines the skeleton of an algorithm in a method\n");

        DataProcessor[] processors = {
            new CsvDataProcessor(),
            new XmlDataProcessor()
        };

        foreach (var processor in processors)
        {
            processor.ProcessData();
        }
    }

    static void DemonstrateFlyweightPattern()
    {
        Console.WriteLine("🔹 FLYWEIGHT PATTERN");
        Console.WriteLine("Minimizes memory usage by sharing intrinsic state\n");

        var treeFactory = new TreeTypeFactory();
        var trees = new List<Tree>();

        // Create trees with shared flyweights
        var oakType = treeFactory.GetTreeType("Oak", "Green", "Rough");
        var pineType = treeFactory.GetTreeType("Pine", "Dark Green", "Smooth");
        var oakType2 = treeFactory.GetTreeType("Oak", "Green", "Rough"); // Should reuse

        trees.Add(new Tree(oakType, 10, 20));
        trees.Add(new Tree(pineType, 15, 25));
        trees.Add(new Tree(oakType2, 20, 30));

        Console.WriteLine($"Total TreeType objects created: {treeFactory.GetTreeTypeCount()}");
        Console.WriteLine("Drawing all trees:");
        foreach (var tree in trees)
        {
            tree.Draw();
        }
        Console.WriteLine();
    }

    static void DemonstrateChainOfResponsibilityPattern()
    {
        Console.WriteLine("🔹 CHAIN OF RESPONSIBILITY PATTERN");
        Console.WriteLine("Passes requests along a chain of handlers\n");

        var manager = new ManagerHandler();
        var director = new DirectorHandler();
        var ceo = new CeoHandler();

        manager.SetNext(director).SetNext(ceo);

        var requests = new[]
        {
            new Request("Purchase", 500, "Office supplies"),
            new Request("Equipment", 2500, "New computer"),
            new Request("Travel", 7500, "Business trip"),
            new Request("Facility", 15000, "Office renovation")
        };

        foreach (var request in requests)
        {
            Console.WriteLine($"Processing {request.Type} request for ${request.Amount}");
            manager.Handle(request);
            Console.WriteLine();
        }
    }

    static void DemonstrateMediatorPattern()
    {
        Console.WriteLine("🔹 MEDIATOR PATTERN");
        Console.WriteLine("Defines how objects interact with each other\n");

        var chatMediator = new ChatMediator();
        var alice = new User("Alice", chatMediator);
        var bob = new User("Bob", chatMediator);
        var charlie = new User("Charlie", chatMediator);

        chatMediator.AddUser(alice);
        chatMediator.AddUser(bob);
        chatMediator.AddUser(charlie);

        alice.SendMessage("Hello everyone!");
        bob.SendMessage("Hi Alice!");
        charlie.SendMessage("Good morning!");
        Console.WriteLine();
    }

    static void DemonstrateMementoPattern()
    {
        Console.WriteLine("🔹 MEMENTO PATTERN");
        Console.WriteLine("Captures and restores an object's internal state\n");

        var textEditor = new TextEditor();
        var caretaker = new Caretaker(textEditor);

        textEditor.Content = "Hello World";
        caretaker.Save();

        textEditor.Content = "Hello Beautiful World";
        caretaker.Save();

        textEditor.Content = "Hello Amazing Beautiful World";
        caretaker.Save();

        caretaker.ShowHistory();
        Console.WriteLine();

        caretaker.Undo();
        caretaker.Undo();
        Console.WriteLine();
    }

    static void DemonstrateVisitorPattern()
    {
        Console.WriteLine("🔹 VISITOR PATTERN");
        Console.WriteLine("Separates algorithms from the objects they operate on\n");

        var products = new List<IProduct>
        {
            new Book("Clean Code", 45.99m, "Robert Martin"),
            new Electronics("Laptop", 1299.99m, "Dell"),
            new Clothing("T-Shirt", 19.99m, "M"),
            new Book("Design Patterns", 59.99m, "Gang of Four")
        };

        var taxCalculator = new TaxCalculator();
        var discountCalculator = new DiscountCalculator();

        Console.WriteLine("Calculating taxes:");
        foreach (var product in products)
        {
            product.Accept(taxCalculator);
        }
        Console.WriteLine($"Total tax: ${taxCalculator.GetTotalTax():F2}");
        Console.WriteLine();

        Console.WriteLine("Calculating discounts:");
        foreach (var product in products)
        {
            product.Accept(discountCalculator);
        }
        Console.WriteLine($"Total discount: ${discountCalculator.GetTotalDiscount():F2}");
        Console.WriteLine();
    }

    static void DemonstrateIteratorPattern()
    {
        Console.WriteLine("🔹 ITERATOR PATTERN");
        Console.WriteLine("Provides a way to access elements of a collection sequentially\n");

        var playlist = new Playlist();
        playlist.AddSong(new Song("Bohemian Rhapsody", "Queen", TimeSpan.FromMinutes(5).Add(TimeSpan.FromSeconds(55))));
        playlist.AddSong(new Song("Hotel California", "Eagles", TimeSpan.FromMinutes(6).Add(TimeSpan.FromSeconds(30))));
        playlist.AddSong(new Song("Stairway to Heaven", "Led Zeppelin", TimeSpan.FromMinutes(8).Add(TimeSpan.FromSeconds(2))));

        var iterator = playlist.CreateIterator();
        int trackNumber = 1;

        Console.WriteLine("Playing playlist:");
        while (iterator.HasNext())
        {
            var song = iterator.Next();
            Console.WriteLine($"Track {trackNumber}: {song}");
            trackNumber++;
        }
        Console.WriteLine();
    }

    static void DemonstrateInterpreterPattern()
    {
        Console.WriteLine("🔹 INTERPRETER PATTERN");
        Console.WriteLine("Defines a grammar and provides an interpreter for it\n");

        var calculator = new Calculator();

        var expressions = new[]
        {
            "5",
            "5 + 3",
            "10 - 4",
            "6 * 2",
            "10 + 5 - 3",
            "4 * 2 + 1"
        };

        foreach (var expression in expressions)
        {
            var result = calculator.Calculate(expression);
            Console.WriteLine($"{expression} = {result}");
        }
        Console.WriteLine();
    }
}
