namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string ToCurrency(this string str)
        {
           
                if(string.IsNullOrEmpty(str)) { throw new ArgumentNullException("Please provide an amount!!"); }
                bool isNumber = int.TryParse(str, out var amount);

                if (!isNumber)
                {
                throw new ArgumentException("Please provide a valid number as an amount!!");
                }
           
                return $"${amount}";

        }
    }
}
