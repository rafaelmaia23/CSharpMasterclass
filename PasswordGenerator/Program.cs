PasswordGenerator passwordGenerator = new PasswordGenerator(new RandomWrap());

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(passwordGenerator.Generate(5, 10, false));
}
Console.ReadKey();

public interface IRandom
{
    int Next(int minValue, int maxValue);
    int Next(int maxValue);
}

public class RandomWrap : IRandom
{
    private readonly Random _random = new Random();
    public int Next(int minValue, int maxValue)
    {
        return _random.Next(minValue, maxValue);
    }

    public int Next(int maxValue)
    {
        return _random.Next(maxValue);
    }
}
public class PasswordGenerator
{
    private readonly IRandom _random;

    public PasswordGenerator(IRandom random)
    {
        _random = random;
    }

    public string Generate(
        int minPasswordLength, int maxPasswordLenggth, bool useSpecialCharacthers)
    {
        //validate max and min length
        if (minPasswordLength < 1)
        {
            throw new ArgumentOutOfRangeException(
                $"Min password length must be greater than 0");
        }
        if (maxPasswordLenggth < minPasswordLength)
        {
            throw new ArgumentOutOfRangeException(
                $"Min password length must be smaller than Max password length");
        }

        //randomly pick the length of password between left and right range
        var passwordRandomLength = _random.Next(minPasswordLength, maxPasswordLenggth + 1);

        //generate random string
        var poolOfPossibleCharachters = useSpecialCharacthers ?
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=" :
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        return new string(Enumerable.Repeat(poolOfPossibleCharachters, passwordRandomLength).Select(chars => chars[_random.Next(chars.Length)]).ToArray());
    }
}
