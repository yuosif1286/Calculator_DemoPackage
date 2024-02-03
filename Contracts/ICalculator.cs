namespace Calculator_Demo.Contracts;

public interface ICalculator
{
    public int Add(List<int> numbers);
    public int Subtract(int a, int b);
    public int Multiply(int a, int b);
    public int Divide(int a, int b);
}
