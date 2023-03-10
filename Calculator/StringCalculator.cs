namespace StringCalculator;

public class StringCalculator
{
    public StringCalculator()
    {
        
    }

    public int Calculate(String input)
    {
        var numbers = SplitInput(input);
        if (numbers.Any(number => number < 0))
        {
            throw new ArgumentException();
        }
        var sum = numbers.Sum();
        return sum;
    }

    private List<int> SplitInput(String input)
    {
        var separators = new List<String>() { ",", "\r\n"};
        return input.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
    }
}