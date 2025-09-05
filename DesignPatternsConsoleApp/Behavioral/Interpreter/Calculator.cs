namespace DesignPatternsConsoleApp.Behavioral.Interpreter;

/// <summary>
/// Context class for the interpreter
/// </summary>
public class Calculator
{
    public int Calculate(string expression)
    {
        // Simple expression parser for demonstration
        // In a real implementation, you would have a proper parser
        var tokens = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        if (tokens.Length == 1)
        {
            return int.Parse(tokens[0]);
        }

        // Simple left-to-right evaluation for demonstration
        var result = int.Parse(tokens[0]);
        
        for (int i = 1; i < tokens.Length; i += 2)
        {
            var operation = tokens[i];
            var operand = int.Parse(tokens[i + 1]);
            
            switch (operation)
            {
                case "+":
                    result = new AddExpression(new NumberExpression(result), new NumberExpression(operand)).Interpret();
                    break;
                case "-":
                    result = new SubtractExpression(new NumberExpression(result), new NumberExpression(operand)).Interpret();
                    break;
                case "*":
                    result = new MultiplyExpression(new NumberExpression(result), new NumberExpression(operand)).Interpret();
                    break;
            }
        }
        
        return result;
    }
}
