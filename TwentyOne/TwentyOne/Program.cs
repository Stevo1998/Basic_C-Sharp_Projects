﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Input;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {            
            //// Notes on using DateTime and TimeSpan
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45); // A value type struct (non-nullable) 
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth; // Gets the difference in days from one DateTime to another

            //// To get text from a file
            //string text = File.ReadAllText(@"C:\Users\Steven Salazar\OneDrive\Escritorio\Basic_C#_Programs\Logs\log.txt");


            //// To write text into a file
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Steven Salazar\OneDrive\Escritorio\Basic_C#_Programs\Logs\log.txt", text); // The @ character allows the compiler to read the string as is
            

            //// using Var
            //var newPlayer = new Player("Jesse"); // Var is used when the data type is clearly shown



            // Actual game program starts here
            const string casinoName = "Grand Hotel and Casino"; // Declaring a constant

            Guid identifier = Guid.NewGuid(); // Creates a global unique identifier

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            if (playerName.ToLower() == "admin") 
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                
                foreach (var exception in Exceptions) 
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") 
            { 
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Steven Salazar\OneDrive\Escritorio\Basic_C#_Programs\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try 
                    { 
                        game.Play(); 
                    } 
                    catch (FraudException ex) 
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception ex) 
                    {
                        Console.WriteLine("An error ocurred. Please contact your system administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");

            Console.Read();
            
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect " +
                                      "Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = "INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES " +
                                 "(@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect " +
                                      "Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection( connectionString)) 
            { 
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) 
                { 
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["ID"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }

                connection.Close();
            }

            return Exceptions;
        }
    }
}
