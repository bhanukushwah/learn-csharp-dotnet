using ExtensionMethods;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the amount");
        string inputAmount = Console.ReadLine();

        try
        {
        string currencyAmount = inputAmount.ToCurrency();
        Console.WriteLine(currencyAmount);
        } catch(ArgumentNullException e)
        {
            Console.WriteLine("{0} First exception caught.", e);
        } catch(Exception e)
        {
            Console.WriteLine("{0} Second exception caught.", e);
        }


    }
}