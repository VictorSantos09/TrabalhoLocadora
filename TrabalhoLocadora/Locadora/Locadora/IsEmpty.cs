namespace Locadora
{
    public static class IsEmpty
    {
        public static string EmptyST(string input)
        {
            while (input == string.Empty)
            {
                Console.WriteLine("Tente Novamente");
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
