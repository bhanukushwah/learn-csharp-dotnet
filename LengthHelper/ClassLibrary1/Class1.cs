namespace LengthHelper
{
    public class LengthHelper
    {
        public static void Main()
        {
            LengthHelper lengthHelper = new LengthHelper();
            Console.WriteLine("Please enter somehing to get length of it: ");
            string input = Console.ReadLine();
            int length = lengthHelper.GetLength(input);
            Console.WriteLine(length);
        }
        public int GetLength(string text)
        {
            return text.Length;
        } 
    }
}