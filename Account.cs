using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indkapsling_C_
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

    internal class Admin : User
    {
        public double AdminBalance { get; private set; }
        public int AdminID { get; }

        public Admin(double initialBalance, int adminID, string firstName, string lastName)
            : base(firstName, lastName)
        {
            AdminBalance = initialBalance;
            AdminID = adminID;
        }

        public Account CreateAccount(Owner owner)
        {
            var account = new Account(AdminBalance, owner.KundeID, owner);
            Console.WriteLine($"Hej {owner.FullName}. Din konto er oprettet med {FullName} som admin.");
            return account;
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
            Balance += amount;
            return UpdateMessage();
        }

        public string RemoveBalance(double amount)
        {
            Balance -= amount;
            return UpdateMessage();
        }

        private string UpdateMessage()
        {
            return $"Din konto er blevet opdateret. Der står nu kr. {Balance}.";
        }
    }

}

