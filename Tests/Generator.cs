namespace Tests
{
    public class Generator
    {
        public string Generate(int userInput)
        {
            if (userInput % 3 == 0)
            {
                return ("Fizz");
            }
            return userInput.ToString();
        }
    }
}