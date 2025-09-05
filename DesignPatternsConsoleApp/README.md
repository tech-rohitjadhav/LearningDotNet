# Design Patterns Console Application - .NET 8

This project demonstrates all 23 classic design patterns from the Gang of Four (GoF) with real-life examples implemented in C# using .NET 8.

## Project Structure

```
DesignPatternsConsoleApp/
├── Creational/                    # Creational Design Patterns
│   ├── Singleton/                # Singleton Pattern
│   ├── FactoryMethod/            # Factory Method Pattern
│   ├── AbstractFactory/          # Abstract Factory Pattern
│   ├── Builder/                  # Builder Pattern
│   └── Prototype/                # Prototype Pattern
├── Structural/                   # Structural Design Patterns
│   ├── Adapter/                  # Adapter Pattern
│   ├── Bridge/                   # Bridge Pattern
│   ├── Composite/                # Composite Pattern
│   ├── Decorator/                # Decorator Pattern
│   ├── Facade/                   # Facade Pattern
│   ├── Flyweight/                # Flyweight Pattern
│   └── Proxy/                    # Proxy Pattern
├── Behavioral/                   # Behavioral Design Patterns
│   ├── Observer/                 # Observer Pattern
│   ├── Strategy/                 # Strategy Pattern
│   ├── Command/                  # Command Pattern
│   ├── State/                    # State Pattern
│   ├── TemplateMethod/           # Template Method Pattern
│   ├── ChainOfResponsibility/    # Chain of Responsibility Pattern
│   ├── Mediator/                 # Mediator Pattern
│   ├── Memento/                  # Memento Pattern
│   ├── Visitor/                  # Visitor Pattern
│   ├── Iterator/                 # Iterator Pattern
│   └── Interpreter/              # Interpreter Pattern
└── Program.cs                    # Main demonstration program
```

## Design Patterns Implemented

### 🏗️ Creational Patterns (5)

#### 1. Singleton Pattern
**Purpose**: Ensures a class has only one instance and provides global access to it.
**Example**: Database connection, Logger
**Key Features**:
- Thread-safe implementation using double-checked locking
- Lazy<T> implementation for modern C# approach
- Global access point for shared resources

#### 2. Factory Method Pattern
**Purpose**: Creates objects without specifying their exact classes.
**Example**: Vehicle manufacturing system
**Key Features**:
- Abstract creator with concrete creators
- Template method for manufacturing process
- Extensible for new vehicle types

#### 3. Abstract Factory Pattern
**Purpose**: Creates families of related objects without specifying their concrete classes.
**Example**: Furniture manufacturing (Modern vs Victorian)
**Key Features**:
- Factory for each product family
- Consistent product families
- Easy to add new furniture styles

#### 4. Builder Pattern
**Purpose**: Constructs complex objects step by step.
**Example**: Computer building system
**Key Features**:
- Fluent interface for building
- Director for predefined configurations
- Flexible object construction

#### 5. Prototype Pattern
**Purpose**: Creates objects by cloning existing instances.
**Example**: Employee management system
**Key Features**:
- Deep cloning implementation
- Registry for prototype management
- Efficient object creation

### 🏗️ Structural Patterns (7)

#### 6. Adapter Pattern
**Purpose**: Allows incompatible interfaces to work together.
**Example**: Legacy printer adapter
**Key Features**:
- Interface compatibility
- Legacy system integration
- Minimal changes to existing code

#### 7. Bridge Pattern
**Purpose**: Separates abstraction from implementation.
**Example**: Shape rendering (Vector vs Raster)
**Key Features**:
- Decoupled abstraction and implementation
- Runtime implementation switching
- Extensible rendering systems

#### 8. Composite Pattern
**Purpose**: Composes objects into tree structures.
**Example**: File system representation
**Key Features**:
- Uniform treatment of individual and composite objects
- Recursive structure
- Tree-like hierarchies

#### 9. Decorator Pattern
**Purpose**: Adds behavior to objects dynamically.
**Example**: Coffee customization system
**Key Features**:
- Runtime behavior modification
- Flexible object enhancement
- Composition over inheritance

#### 10. Facade Pattern
**Purpose**: Provides a simplified interface to a complex subsystem.
**Example**: Computer startup/shutdown system
**Key Features**:
- Simplified client interface
- Complex subsystem hiding
- Single entry point

#### 11. Flyweight Pattern
**Purpose**: Minimizes memory usage by sharing intrinsic state.
**Example**: Tree rendering system
**Key Features**:
- Shared intrinsic state
- Extrinsic state separation
- Memory optimization

#### 12. Proxy Pattern
**Purpose**: Provides a placeholder for another object.
**Example**: Image loading proxy
**Key Features**:
- Lazy loading
- Access control
- Caching capabilities

### 🎭 Behavioral Patterns (11)

#### 13. Observer Pattern
**Purpose**: Defines a one-to-many dependency between objects.
**Example**: News agency and subscribers
**Key Features**:
- Loose coupling between subject and observers
- Dynamic subscription management
- Event-driven architecture

#### 14. Strategy Pattern
**Purpose**: Defines a family of algorithms and makes them interchangeable.
**Example**: Payment processing system
**Key Features**:
- Runtime algorithm selection
- Algorithm encapsulation
- Easy algorithm addition

#### 15. Command Pattern
**Purpose**: Encapsulates a request as an object.
**Example**: Remote control system
**Key Features**:
- Request encapsulation
- Undo/redo functionality
- Queue and logging support

#### 16. State Pattern
**Purpose**: Allows an object to alter its behavior when its internal state changes.
**Example**: Vending machine system
**Key Features**:
- State-specific behavior
- Clean state transitions
- Eliminates conditional statements

#### 17. Template Method Pattern
**Purpose**: Defines the skeleton of an algorithm in a method.
**Example**: Data processing pipeline
**Key Features**:
- Algorithm structure definition
- Step customization
- Code reuse

#### 18. Chain of Responsibility Pattern
**Purpose**: Passes requests along a chain of handlers.
**Example**: Approval system
**Key Features**:
- Request handling chain
- Dynamic handler addition
- Decoupled sender and receiver

#### 19. Mediator Pattern
**Purpose**: Defines how objects interact with each other.
**Example**: Chat system
**Key Features**:
- Centralized communication
- Reduced object coupling
- Simplified object interaction

#### 20. Memento Pattern
**Purpose**: Captures and restores an object's internal state.
**Example**: Text editor with undo functionality
**Key Features**:
- State preservation
- Undo/redo capabilities
- State history management

#### 21. Visitor Pattern
**Purpose**: Separates algorithms from the objects they operate on.
**Example**: Shopping cart with different calculations
**Key Features**:
- Algorithm separation
- Easy algorithm addition
- Double dispatch

#### 22. Iterator Pattern
**Purpose**: Provides a way to access elements of a collection sequentially.
**Example**: Music playlist system
**Key Features**:
- Collection traversal
- Uniform iteration interface
- Multiple iteration algorithms

#### 23. Interpreter Pattern
**Purpose**: Defines a grammar and provides an interpreter for it.
**Example**: Simple calculator
**Key Features**:
- Grammar definition
- Expression evaluation
- Language interpretation

## How to Run

1. **Prerequisites**: .NET 8 SDK installed
2. **Navigate to project directory**:
   ```bash
   cd DesignPatternsConsoleApp
   ```
3. **Run the application**:
   ```bash
   dotnet run
   ```

## Key Benefits Demonstrated

- **Code Reusability**: Patterns promote reusable solutions
- **Maintainability**: Well-structured, easy-to-modify code
- **Extensibility**: Easy to add new features without breaking existing code
- **Flexibility**: Runtime behavior changes and configuration
- **Separation of Concerns**: Clear responsibilities for each class
- **Loose Coupling**: Reduced dependencies between components

## Real-World Applications

Each pattern represents common scenarios in enterprise applications:
- **Singleton**: Database connections, configuration managers, loggers
- **Factory**: Object creation in frameworks, plugin systems
- **Observer**: Event systems, MVC architectures, reactive programming
- **Strategy**: Payment processing, sorting algorithms, validation rules
- **Command**: Undo/redo functionality, macro recording, queuing systems
- **State**: Game development, workflow engines, UI state management
- **Adapter**: Legacy system integration, third-party library wrapping
- **Decorator**: Middleware, filters, aspect-oriented programming
- **Facade**: API design, complex system simplification
- **Proxy**: Caching, lazy loading, access control, remote procedure calls

## Learning Outcomes

After studying this project, you will understand:
- When and how to apply each design pattern
- The trade-offs and benefits of each pattern
- How patterns work together in real applications
- Best practices for implementing patterns in C#
- Common anti-patterns and how to avoid them

This comprehensive implementation serves as both a learning resource and a reference guide for applying design patterns in your own projects.
