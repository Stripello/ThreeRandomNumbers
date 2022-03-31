using ThreeNumbers;

var answer = AskNumbers.Ask();
if (answer == null)
{
    return;
}

var randomizer = new Random();
var firstNumber = randomizer.Next(answer.Value.minValue, answer.Value.maxValue + 1);
Console.WriteLine($"First number = {firstNumber}");

var secondNumber = randomizer.Next(answer.Value.minValue, answer.Value.maxValue + 1);
Console.WriteLine($"Second number = {secondNumber}");

var thirdNumber = randomizer.Next(answer.Value.minValue, answer.Value.maxValue + 1);
Console.WriteLine($"Third number = {thirdNumber}");

var midpointPosition = (int)answer.Value.decimalPlace;
var mean = (double)(firstNumber + secondNumber + thirdNumber) / 3;
Console.WriteLine($"Algebraic mean = {Math.Round(mean, midpointPosition)}");

mean = Math.Pow(firstNumber * secondNumber * thirdNumber, (double)1 / 3);
Console.WriteLine($"Geometrical mean = {Math.Round(mean, midpointPosition)}");

if (firstNumber != 0)
{
    mean = (double)secondNumber / firstNumber;
    Console.WriteLine($"Division of second number by first number = {Math.Round(mean, midpointPosition)}");
    mean = (double)thirdNumber / firstNumber;
    Console.WriteLine($"Division of third number by first number = {Math.Round(mean, midpointPosition)}");
}
if (secondNumber != 0)
{
    mean = (double)firstNumber / secondNumber;
    Console.WriteLine($"Division of first nubmer by second number = {Math.Round(mean, midpointPosition)}");
    mean = (double)thirdNumber / secondNumber;
    Console.WriteLine($"Division of third number by second number = {Math.Round(mean, midpointPosition)}");
}
if (thirdNumber != 0)
{
    mean = (double)firstNumber / thirdNumber;
    Console.WriteLine($"Division of first number by third number = {Math.Round(mean, midpointPosition)}");

    mean = (double)secondNumber / thirdNumber;
    Console.WriteLine($"Division of second number by third number = {Math.Round(mean, midpointPosition)}");
}

/*
 * access to tupple fields problem
 */