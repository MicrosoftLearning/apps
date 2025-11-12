namespace CSharpCompilerWasm;

public static class ConsoleCodeProvider
{
    public static string GetConsoleReplacementCode()
    {
        return @"
public static class Console
{
    private static System.Text.StringBuilder _output = new System.Text.StringBuilder();
    private static System.Collections.Generic.Queue<string> _inputQueue = new System.Collections.Generic.Queue<string>();
    
    public static void WriteLine()
    {
        _output.Append(""\n"");
    }
    
    public static void WriteLine(string value)
    {
        _output.Append(value ?? """");
        _output.Append(""\n"");
    }
    
    public static void WriteLine(char value)
    {
        _output.Append(value.ToString());
        _output.Append(""\n"");
    }
    
    public static void WriteLine(object value)
    {
        _output.Append(value?.ToString() ?? """");
        _output.Append(""\n"");
    }
    
    public static void WriteLine(int value)
    {
        _output.Append(value.ToString());
        _output.Append(""\n"");
    }
    
    public static void WriteLine(long value)
    {
        _output.Append(value.ToString());
        _output.Append(""\n"");
    }
    
    public static void WriteLine(float value)
    {
        _output.Append(value.ToString());
        _output.Append(""\n"");
    }
    
    public static void WriteLine(double value)
    {
        _output.Append(value.ToString());
        _output.Append(""\n"");
    }
    
    public static void WriteLine(decimal value)
    {
        _output.Append(value.ToString());
        _output.Append(""\n"");
    }
    
    public static void WriteLine(bool value)
    {
        _output.Append(value.ToString());
        _output.Append(""\n"");
    }
    
    public static void Write(string value)
    {
        _output.Append(value ?? """");
    }
    
    public static void Write(char value)
    {
        _output.Append(value.ToString());
    }
    
    public static void Write(object value)
    {
        _output.Append(value?.ToString() ?? """");
    }
    
    public static void Write(int value)
    {
        _output.Append(value.ToString());
    }
    
    public static void Write(long value)
    {
        _output.Append(value.ToString());
    }
    
    public static void Write(float value)
    {
        _output.Append(value.ToString());
    }
    
    public static void Write(double value)
    {
        _output.Append(value.ToString());
    }
    
    public static void Write(decimal value)
    {
        _output.Append(value.ToString());
    }
    
    public static void Write(bool value)
    {
        _output.Append(value.ToString());
    }
    
    public static string ReadLine()
    {
        if (_inputQueue.Count > 0)
        {
            var input = _inputQueue.Dequeue();
            _output.Append(input);
            _output.Append(""\n"");
            return input;
        }
        
        throw new System.InvalidOperationException(""INPUT_REQUIRED"");
    }
    
    internal static string GetCapturedOutput()
    {
        return _output.ToString();
    }
    
    internal static void ClearOutput()
    {
        _output.Clear();
        _inputQueue.Clear();
    }
    
    internal static void ProvideInput(string input)
    {
        _inputQueue.Enqueue(input ?? """");
    }
}
";
    }
}
