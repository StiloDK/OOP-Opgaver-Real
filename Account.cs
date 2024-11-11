using System;

namespace Day6_MoreBank
{
    internal abstract class User
    {
        public string FirstName { get; }
        public string LastName { get; }

        protected User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FullName => $"{FirstName} {LastName}";
    }

    internal class Owner : User
    {
        public int KundeID { get; }

        public Owner(int kundeID, string firstName, string lastName)
            : base(firstName, lastName)
        {
            KundeID = kundeID;
        }
    }

    internal class Account
    {
        public double Balance { get; private set; }
        public int ID { get; }
        public Owner AccountOwner { get; }

        public Account(double initialBalance, int id, Owner owner)
        {
            Balance = initialBalance;
            ID = id;
            AccountOwner = owner;
        }

        public string AddBalance(double amount)
        {
            try
            {
                if (double.IsNaN(amount))
                    throw new FormatException("Indtastningen er ikke et gyldigt tal.");

                if (amount < 0)
                    throw new ArgumentException("Beløbet kan ikke være negativt.");

                Balance += amount;
                return UpdateMessage();
            }
            catch (FormatException ex)
            {
                return $"Fejl: {ex.Message}. Prøv venligst igen.";
            }
            catch (ArgumentException ex)
            {
                return $"Fejl: {ex.Message}. Prøv venligst igen.";
            }
            finally
            {
                Console.WriteLine($"Beløb forsøgt indsat: {amount}");
            }
        }

        public string RemoveBalance(double amount)
        {
            try
            {
                if (double.IsNaN(amount))
                    throw new FormatException("Indtastningen er ikke et gyldigt tal.");

                if (amount < 0)
                    throw new ArgumentException("Beløbet kan ikke være negativt.");

                if (amount > Balance)
                    throw new InvalidOperationException("Beløbet er større end den nuværende balance.");

                Balance -= amount;
                return UpdateMessage();
            }
            catch (FormatException ex)
            {
                return $"Fejl: {ex.Message}. Prøv venligst igen.";
            }
            catch (ArgumentException ex)
            {
                return $"Fejl: {ex.Message}. Prøv venligst igen.";
            }
            catch (InvalidOperationException ex)
            {
                return $"Fejl: {ex.Message}. Prøv venligst igen.";
            }
            finally
            {
                Console.WriteLine($"Beløb forsøgt hævet: {amount}");
            }
        }

        private string UpdateMessage()
        {
            return $"Din konto er blevet opdateret. Der står nu kr. {Balance}.";
        }
    }
}
