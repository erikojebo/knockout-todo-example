namespace KnockoutTodoExample
{
    public static class StringExtensions
    {
        public static string ToCamelCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input[0].ToString().ToLower() + input.Substring(1);
        }
    }
}