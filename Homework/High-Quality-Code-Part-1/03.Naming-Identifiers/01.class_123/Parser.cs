namespace VariableConversion
{
    using System;

    public class Parser
    {
        private const int MaxExecutionCount = 6;

        public void ConvertedToString(bool isString)
        {
            string convertedToString = isString.ToString();
            Console.WriteLine(convertedToString);
        }
    }
}