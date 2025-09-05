namespace DesignPatternsConsoleApp.Behavioral.ChainOfResponsibility;

/// <summary>
/// Base handler class
/// </summary>
public abstract class ApprovalHandler : IHandler
{
    private IHandler? _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual void Handle(Request request)
    {
        if (_nextHandler != null)
        {
            _nextHandler.Handle(request);
        }
        else
        {
            Console.WriteLine($"Request of type '{request.Type}' for ${request.Amount} could not be processed by any handler");
        }
    }
}

/// <summary>
/// Concrete Handler - Manager
/// </summary>
public class ManagerHandler : ApprovalHandler
{
    public override void Handle(Request request)
    {
        if (request.Amount <= 1000)
        {
            Console.WriteLine($"Manager approved {request.Type} request for ${request.Amount}: {request.Description}");
        }
        else
        {
            Console.WriteLine($"Manager cannot approve {request.Type} request for ${request.Amount}, passing to next handler");
            base.Handle(request);
        }
    }
}

/// <summary>
/// Concrete Handler - Director
/// </summary>
public class DirectorHandler : ApprovalHandler
{
    public override void Handle(Request request)
    {
        if (request.Amount <= 5000)
        {
            Console.WriteLine($"Director approved {request.Type} request for ${request.Amount}: {request.Description}");
        }
        else
        {
            Console.WriteLine($"Director cannot approve {request.Type} request for ${request.Amount}, passing to next handler");
            base.Handle(request);
        }
    }
}

/// <summary>
/// Concrete Handler - CEO
/// </summary>
public class CeoHandler : ApprovalHandler
{
    public override void Handle(Request request)
    {
        if (request.Amount <= 10000)
        {
            Console.WriteLine($"CEO approved {request.Type} request for ${request.Amount}: {request.Description}");
        }
        else
        {
            Console.WriteLine($"CEO cannot approve {request.Type} request for ${request.Amount}, request denied");
        }
    }
}
