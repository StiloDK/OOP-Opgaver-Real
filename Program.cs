using Indkapsling_C_;

namespace Indkapsling_CSharp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Owner owner = new Owner(123456, "Daniel", "Jensen");

            Account account = new Account(100, 123456, owner);
            Console.WriteLine($"Hej {owner.FullName}, din konto er oprettet.");

            double depositAmount = Convert.ToDouble(Console.ReadLine());
            string depositMessage = account.AddBalance(depositAmount);
            Console.WriteLine(depositMessage);

            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            string withdrawMessage = account.RemoveBalance(withdrawAmount);
            Console.WriteLine(withdrawMessage);

        }
    }
}