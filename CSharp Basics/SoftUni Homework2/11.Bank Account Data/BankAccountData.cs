using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Ivanov";
            string lastName = "Ivanov";
            int balance = 1568;
            string bankName = "Sample Bulgarian Bank";

            //I am saving the IBAN and card numbers as strings because the numbers are permanent and are not likely to change
            string iban = "1783211987";
            string firstCardNumber = "4987-5678-1234-5679";
            string secondCardNumber = "1234-5678-9012-3456";
            string thirdCardNumber = "1345-6765-3490-6546";

            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Middle Name: {0}", middleName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Bank Balance: {0}", balance);
            Console.WriteLine("Bank Name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("First Credit Card Number: {0}", firstCardNumber);
            Console.WriteLine("Second Credit Card Number: {0}", secondCardNumber);
            Console.WriteLine("Third Credit Card Number: {0}", thirdCardNumber);

        }
    }