namespace ThreeNumbers
{
    internal static class AskNumbers
    {
        internal static (int minValue, int maxValue, uint decimalPlace)? Ask()
        {
            (int minValue, int maxValue, uint decimalPlace) answer;
            string userAnswer;
            do
            {
                Console.WriteLine("Enter first border number. Or type \"EXIT\" to terminate process.");
                userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "exit")
                {
                    return null;
                }
                if (int.TryParse(userAnswer, out answer.minValue))
                {
                    break;
                }
                Console.WriteLine("Can't parse entered string.");
            }
            while (true);

            do
            {
                Console.WriteLine("Enter second bordernumber. Or type \"EXIT\" to terminate process.");
                userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "exit")
                {
                    return null;
                }
                if (int.TryParse(userAnswer, out answer.maxValue))
                {
                    if (answer.minValue > answer.maxValue)
                    {
                        (answer.maxValue, answer.minValue) = (answer.minValue, answer.maxValue);
                    }
                    break;
                }
                Console.WriteLine("Can't parse entered string.");
            }
            while (true);

            do
            {
                Console.WriteLine("Enter amount of digits after decimal divider. Or type \"EXIT\" to terminate process.");
                userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "exit")
                {
                    return null;
                }
                if (uint.TryParse(userAnswer, out answer.decimalPlace))
                {
                    break;
                }
                Console.WriteLine("Can't parse entered string.");
            }
            while (true);

            return answer;
        }
    }
}
