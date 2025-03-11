using System;
using OOP;

class MainProgram
{
    public static void Main()
    {
        string correctUsername = "admin";
        string correctPassword = "admin";

        while (true)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful!\n");

                OOP.ManageProduct.InsertNewProduct newProduct = new OOP.ManageProduct.InsertNewProduct();

                Console.Write("How many products do you want to insert? ");
                int count = int.Parse(Console.ReadLine());

                for (int i = 1; i <= count; i++)
                {
                    Console.Write($"Enter product name for item {i}: ");
                    string productName = Console.ReadLine();

                    Console.Write($"Enter product price for item {i}: ");
                    int productPrice = int.Parse(Console.ReadLine());

                    Console.Write($"Enter product description for item {i}: ");
                    string productDescription = Console.ReadLine();

                    newProduct.InsertData(productName, productPrice, productDescription);
                }
            }
            else
            {
                Console.WriteLine(@"

                             ▄▄▄·  ▄▄·  ▄▄· ▄▄▄ ..▄▄ · .▄▄ ·     ·▄▄▄▄  ▄▄▄ . ▐ ▄ ▪  ▄▄▄ .·▄▄▄▄  ▄▄ 
                            ▐█ ▀█ ▐█ ▌▪▐█ ▌▪▀▄.▀·▐█ ▀. ▐█ ▀.     ██▪ ██ ▀▄.▀·•█▌▐███ ▀▄.▀·██▪ ██ ██▌
                            ▄█▀▀█ ██ ▄▄██ ▄▄▐▀▀▪▄▄▀▀▀█▄▄▀▀▀█▄    ▐█· ▐█▌▐▀▀▪▄▐█▐▐▌▐█·▐▀▀▪▄▐█· ▐█▌▐█·
                            ▐█ ▪▐▌▐███▌▐███▌▐█▄▄▌▐█▄▪▐█▐█▄▪▐█    ██. ██ ▐█▄▄▌██▐█▌▐█▌▐█▄▄▌██. ██ .▀ 
                             ▀  ▀ ·▀▀▀ ·▀▀▀  ▀▀▀  ▀▀▀▀  ▀▀▀▀     ▀▀▀▀▀•  ▀▀▀ ▀▀ █▪▀▀▀ ▀▀▀ ▀▀▀▀▀•  ▀                                                        

");
            }

            Console.Write("Do you want to input again? (y/n): ");
            string retry = Console.ReadLine().ToLower();
            if (retry != "y")
            {
                break;
            }
        }
    }
}
