using System;

namespace Day6_MoreBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner(123456, "Daniel", "Jensen");
            Account account = new Account(100, 123456, owner);
            Console.WriteLine($"Hej {owner.FullName}, din konto er oprettet.");

            while (true)
            {
                try
                {
                    Console.WriteLine("Indtast beløb til indsættelse:");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    string depositMessage = account.AddBalance(depositAmount);
                    Console.WriteLine(depositMessage);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ugyldigt input. Beløbet skal være et gyldigt tal. Prøv igen.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Ugyldigt beløb. Beløbet kan ikke være negativt. Prøv igen.");
                }
                finally
                {
                    Console.WriteLine("Forsøg på indsættelse afsluttet.");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Indtast beløb til hævning:");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    string withdrawMessage = account.RemoveBalance(withdrawAmount);
                    Console.WriteLine(withdrawMessage);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ugyldigt input. Beløbet skal være et gyldigt tal. Prøv igen.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Ugyldigt beløb. Beløbet kan ikke være negativt. Prøv igen.");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Ugyldigt hævebeløb. Beløbet overstiger saldoen. Prøv igen.");
                }
                finally
                {
                    Console.WriteLine("Forsøg på hævning afsluttet.");
                }
            }
        }
    }
}
