using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Insert company name: ");
            string compName = Console.ReadLine();
            Console.Write("Please insert the company's address: ");
            string compAddress = Console.ReadLine();
            Console.Write("Please insert the company's phone number: ");
            string compNumber = Console.ReadLine();
            Console.Write("Please insert the company's fax number: ");
            string compFax = Console.ReadLine();
            Console.Write("Please insert the company's website: ");
            string compWebsite = Console.ReadLine();
            Console.Write("Please insert the manager's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please insert the manager's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please insert the manager's age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Please insert the manager's phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("---------------------------");

            Console.WriteLine("Company Name: {0}", compName);
            Console.WriteLine("Address: {0}", compAddress);
            Console.WriteLine("Tel. {0}", compNumber);
            Console.WriteLine("Fax Number: {0}", compFax);
            Console.WriteLine("Website: {0}", compWebsite);
            Console.WriteLine("Manager's First Name: {0}", firstName);
            Console.WriteLine("Manager's Last Name: {0}", lastName);
            Console.WriteLine("Manager's Age: {0}", age);
            Console.WriteLine("Manager's Phone Number: {0}", phoneNumber);

        }
    }
