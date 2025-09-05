# SOLID Principles Example - .NET 8 Console Application

This project demonstrates the five SOLID principles of object-oriented design with real-life examples implemented in C# using .NET 8.

## Project Structure

```
LearningDotNet/
├── SolidPrinciplesConsoleApp/
│   ├── SingleResponsibility/     # S - Single Responsibility Principle
│   ├── OpenClosed/              # O - Open/Closed Principle
│   ├── LiskovSubstitution/      # L - Liskov Substitution Principle
│   ├── InterfaceSegregation/    # I - Interface Segregation Principle
│   ├── DependencyInversion/     # D - Dependency Inversion Principle
│   └── Program.cs               # Main demonstration program
└── LearningDotNet.sln   # Solution file
```

## SOLID Principles Demonstrated

### 1. Single Responsibility Principle (SRP)
**"A class should have only one reason to change"**

**Example**: User Management System
- `UserService`: Handles user business logic
- `UserRepository`: Handles data persistence
- `EmailService`: Handles email operations
- `User`: Represents user data

Each class has a single, well-defined responsibility.

### 2. Open/Closed Principle (OCP)
**"Software entities should be open for extension, but closed for modification"**

**Example**: Shape Area Calculator
- `IShape`: Base interface for all shapes
- `Circle`, `Rectangle`, `Triangle`: Concrete shape implementations
- `AreaCalculator`: Works with any shape implementing `IShape`

New shapes can be added without modifying existing code.

### 3. Liskov Substitution Principle (LSP)
**"Objects of a superclass should be replaceable with objects of a subclass"**

**Example**: Bird Zoo System
- `IBird`: Base interface for all birds
- `IFlyableBird`, `ISwimmableBird`: Specific behavior interfaces
- `Eagle`, `Penguin`, `Duck`: Different bird implementations

All bird types can be substituted without breaking functionality.

### 4. Interface Segregation Principle (ISP)
**"Clients should not be forced to depend on interfaces they don't use"**

**Example**: Workplace Management System
- `IWorker`: Basic work functionality
- `IEater`, `ISleeper`: Separate behavior interfaces
- `IManager`: Management-specific interface
- `HumanWorker`, `RobotWorker`, `Manager`: Different worker types

Each worker type implements only the interfaces it needs.

### 5. Dependency Inversion Principle (DIP)
**"Depend on abstractions, not concretions"**

**Example**: Order Management System
- `IOrderRepository`: Data access abstraction
- `INotificationService`: Notification abstraction
- `ILogger`: Logging abstraction
- `OrderService`: High-level module depending on abstractions

Dependencies are injected, making the system flexible and testable.

## How to Run

1. **Prerequisites**: .NET 8 SDK installed
2. **Navigate to project directory**:
   ```bash
   cd SolidPrinciplesConsoleApp
   ```
3. **Run the application**:
   ```bash
   dotnet run
   ```

## Key Benefits Demonstrated

- **Maintainability**: Each principle makes the code easier to maintain
- **Extensibility**: New features can be added without breaking existing code
- **Testability**: Dependencies can be easily mocked for testing
- **Flexibility**: Different implementations can be swapped easily
- **Reusability**: Components can be reused in different contexts

## Real-Life Applications

These examples represent common scenarios in enterprise applications:
- User management and authentication
- Shape/geometry calculations in graphics or CAD systems
- Animal/zoo management systems
- Employee/workplace management
- E-commerce order processing

Each principle addresses real-world software design challenges and provides solutions that lead to more robust, maintainable, and scalable applications.
