﻿using System;
using MySql.Data.MySqlClient;

namespace OOP
{
    class ManageProduct
    {
        public class InsertNewProduct
        {
            private readonly string connString = "Server=localhost;Database=sirjonas2b;User ID=root;Password=;";

            public void InsertData(string productName, int productPrice, string productDescription)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        string query = "INSERT INTO products (productName, productPrice, productDescription) VALUES (@name, @price, @description)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", productName);
                            cmd.Parameters.AddWithValue("@price", productPrice);
                            cmd.Parameters.AddWithValue("@description", productDescription);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine(@"
                      ██████  █    ██  ▄████▄   ▄████▄ ▓█████   ██████   ██████  ▐██▌ ▐██▌ 
                     ▒██    ▒  ██  ▓██▒▒██▀ ▀█  ▒██▀ ▀█ ▓█   ▀ ▒██    ▒ ▒██    ▒  ▐██▌ ▐██▌ 
                     ░ ▓██▄   ▓██  ▒██░▒▓█    ▄ ▒▓█    ▄▒███   ░ ▓██▄   ░ ▓██▄    ▐██▌ ▐██▌  
                       ▒   ██▒▓▓█  ░██░▒▓▓▄ ▄██▒▒▓▓▄ ▄██▒▓█  ▄   ▒   ██▒  ▒   ██▒ ▓██▒ ▓██▒ 
                     ▒██████▒▒▒▒█████▓ ▒ ▓███▀ ░▒ ▓███▀ ░▒████▒▒██████▒▒▒██████▒▒ ▒▄▄  ▒▄▄  
                     ▒ ▒▓▒ ▒ ░░▒▓▒ ▒ ▒ ░ ░▒ ▒  ░░ ░▒ ▒  ░░ ▒░ ░▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░ ░▀▀▒ ░▀▀▒ 
                     ░ ░▒  ░ ░░░▒░ ░ ░   ░  ▒     ░  ▒   ░ ░  ░░ ░▒  ░ ░░ ░▒  ░ ░ ░  ░ ░  ░ ░ 
                     ░  ░   ░░░ ░ ░ ░        ░          ░   ░  ░  ░  ░  ░  ░      ░    ░ 
                        ░     ░     ░ ░      ░ ░        ░  ░      ░        ░   ░    ░  
                                    ░        ░                                          
");
                            }
                            else
                            {
                                Console.WriteLine(@"

                    █████▒▄▄▄       ██▓ ██▓    ▓█████ ▓█████▄    ▄▄▄█████▓ ▒█████      ██▓ ███▄    █   ██████ ▓█████  ██▀███  ▄▄▄█████▓
                    ▓██   ▒▒████▄    ▓██▒▓██▒    ▓█   ▀ ▒██▀ ██▌   ▓  ██▒ ▓▒▒██▒  ██▒   ▓██▒ ██ ▀█   █ ▒██    ▒ ▓█   ▀ ▓██ ▒ ██▒▓  ██▒ ▓▒
                    ▒████ ░▒██  ▀█▄  ▒██▒▒██░    ▒███   ░██   █▌   ▒ ▓██░ ▒░▒██░  ██▒   ▒██▒▓██  ▀█ ██▒░ ▓██▄   ▒███   ▓██ ░▄█ ▒▒ ▓██░ ▒░
                    ░▓█▒  ░░██▄▄▄▄██ ░██░▒██░    ▒▓█  ▄ ░▓█▄   ▌   ░ ▓██▓ ░ ▒██   ██░   ░██░▓██▒  ▐▌██▒  ▒   ██▒▒▓█  ▄ ▒██▀▀█▄  ░ ▓██▓ ░ 
                    ░▒█░    ▓█   ▓██▒░██░░██████▒░▒████▒░▒████▓      ▒██▒ ░ ░ ████▓▒░   ░██░▒██░   ▓██░▒██████▒▒░▒████▒░██▓ ▒██▒  ▒██▒ ░ 
                     ▒ ░    ▒▒   ▓▒█░░▓  ░ ▒░▓  ░░░ ▒░ ░ ▒▒▓  ▒      ▒ ░░   ░ ▒░▒░▒░    ░▓  ░ ▒░   ▒ ▒ ▒ ▒▓▒ ▒ ░░░ ▒░ ░░ ▒▓ ░▒▓░  ▒ ░░   
                     ░       ▒   ▒▒ ░ ▒ ░░ ░ ▒  ░ ░ ░  ░ ░ ▒  ▒        ░      ░ ▒ ▒░     ▒ ░░ ░░   ░ ▒░░ ░▒  ░ ░ ░ ░  ░  ░▒ ░ ▒░    ░    
                     ░ ░     ░   ▒    ▒ ░  ░ ░      ░    ░ ░  ░      ░      ░ ░ ░ ▒      ▒ ░   ░   ░ ░ ░  ░  ░     ░     ░░   ░   ░      
                                 ░  ░ ░      ░  ░   ░  ░   ░                    ░ ░      ░           ░       ░     ░  ░   ░              
                                     ░                                                                               ");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"MySQL Error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
