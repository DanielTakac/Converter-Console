using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Converter{

    public class Program{

        public static void Main(string[] args){

            bool running = true;

            while (running){

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("---------");
                Console.WriteLine("Main Menu");
                Console.WriteLine("---------");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n1");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Hash");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("2");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Binary");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("3");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Hexadecimal");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("4");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Morse Code\n\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("0");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Exit\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                int decision1 = Convert.ToInt32(Console.ReadLine());

                switch (decision1){

                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Hash();
                        break;
                    case 2:
                        Binary();
                        break;
                    case 3:
                        Hexadecimal();
                        break;
                    case 4:
                        MorseCode();
                        break;
                    default:
                        break;

                }

            }

            void Hash(){

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("----");
                Console.WriteLine("Hash");
                Console.WriteLine("----");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n1");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Text to Hash\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("2");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Hash to Text\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                int decision2 = Convert.ToInt32(Console.ReadLine());

                switch (decision2){

                    case 1:

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("------------");
                        Console.WriteLine("Text to Hash");
                        Console.WriteLine("------------");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nText: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string input1 = Console.ReadLine();

                        var output1 = Functions.HashString(input1);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"\nHash: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(output1);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPress any button to go back to main menu");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.ReadKey();

                        break;
                    case 2:

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("------------");
                        Console.WriteLine("Hash to Text");
                        Console.WriteLine("------------");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nHash: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string input2 = Console.ReadLine();

                        var output2 = Functions.UnhashString(input2);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"\nText:");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(output2);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPress any button to go back to main menu");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.ReadKey();

                        break;
                    default:
                        return;

                }

            }

            void Binary(){

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------");
                Console.WriteLine("Binary");
                Console.WriteLine("------");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n1");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Text to Binary");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("2");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Binary to Text\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                int decision2 = Convert.ToInt32(Console.ReadLine());

                switch (decision2){

                    case 1:

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("--------------");
                        Console.WriteLine("Text to Binary");
                        Console.WriteLine("--------------");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nText: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string input1 = Console.ReadLine();

                        var output1 = Functions.StringToBinary(input1);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"\nBinary: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(output1);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPress any button to go back to main menu");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.ReadKey();

                        break;
                    case 2:

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("--------------");
                        Console.WriteLine("Binary to Text");
                        Console.WriteLine("--------------");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nBinary: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string input2 = Console.ReadLine();

                        var output2 = Functions.BinaryToString(input2);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"\nText: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(output2);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPress any button to go back to main menu");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.ReadKey();

                        break;
                    default:
                        return;

                }

            }

            void Hexadecimal(){

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------");
                Console.WriteLine("Hexadecimal");
                Console.WriteLine("-----------");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n1");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Text to Hexadecimal");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("2");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" - Hexadecimal to Text\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                int decision2 = Convert.ToInt32(Console.ReadLine());

                switch (decision2){

                    case 1:

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Text to Hexadecimal");
                        Console.WriteLine("-------------------");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nText: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string input1 = Console.ReadLine();

                        var output1 = Functions.StringToHex(input1);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"\nHex: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(output1);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPress any button to go back to main menu");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.ReadKey();

                        break;
                    case 2:

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Hexadecimal to Text");
                        Console.WriteLine("-------------------");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nHex: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string input2 = Console.ReadLine();

                        var output2 = Functions.HexToString(input2);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"\nText: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(output2);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nPress any button to go back to main menu");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.ReadKey();

                        break;
                    default:
                        return;

                }

            }

            void MorseCode(){

                Console.WriteLine("To be added...");

                Console.ReadKey();

            }

        }

    }

}
