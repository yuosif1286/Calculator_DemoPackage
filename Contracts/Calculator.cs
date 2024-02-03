
using System.Diagnostics.CodeAnalysis;

namespace Calculator_Demo.Contracts;

public class Calculator : ICalculator
{
    public int Add(List<int> numbers)
    {
        var sum = 0;
        foreach (var i in numbers) 
            sum += i;
        return sum;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}
