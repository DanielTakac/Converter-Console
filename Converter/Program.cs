using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Converter {
    
    public class Program {

        public static void Main(string[] args) {

            bool running = true;

            while (running) {
                
                Console.Clear();

                ColorText.WriteLineColor("---------", ConsoleColor.Yellow);
                ColorText.WriteLineColor("Main Menu", ConsoleColor.Yellow);
                ColorText.WriteLineColor("---------", ConsoleColor.Yellow);

                ColorText.WriteColor("\n1", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Hash", ConsoleColor.Cyan);
                ColorText.WriteColor("2", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Binary", ConsoleColor.Cyan);
                ColorText.WriteColor("3", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Hexadecimal", ConsoleColor.Cyan);
                ColorText.WriteColor("4", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Morse Code\n\n", ConsoleColor.Cyan);
                ColorText.WriteColor("0", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Exit\n", ConsoleColor.Cyan);

                int decision1 = Convert.ToInt32(ColorText.ReadLineColor(ConsoleColor.Yellow));

                switch (decision1) {

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

            void Hash() {

                Console.Clear();

                ColorText.WriteLineColor("----", ConsoleColor.Yellow);
                ColorText.WriteLineColor("Hash", ConsoleColor.Yellow);
                ColorText.WriteLineColor("----", ConsoleColor.Yellow);

                ColorText.WriteColor("\n1", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Text to Hash\n", ConsoleColor.Cyan);
                ColorText.WriteColor("2", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Hash to Text\n", ConsoleColor.Cyan);

                int decision2 = Convert.ToInt32(ColorText.ReadLineColor(ConsoleColor.Yellow));

                switch (decision2) {

                    case 1:

                        Console.Clear();

                        ColorText.WriteLineColor("------------", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("Text to Hash", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("------------", ConsoleColor.Yellow);

                        ColorText.WriteColor("\nText: ", ConsoleColor.Cyan);

                        string input1 = ColorText.ReadLineColor(ConsoleColor.Yellow);

                        var output1 = Functions.HashString(input1);

                        ColorText.WriteColor($"\nHash: ", ConsoleColor.Cyan);
                        ColorText.WriteLineColor(output1, ConsoleColor.Yellow);

                        ColorText.WriteLineColor("\nPress any button to go back to main menu", ConsoleColor.Cyan);

                        ColorText.ReadKeyColor(ConsoleColor.Yellow);

                        break;
                        
                    case 2:

                        Console.Clear();

                        ColorText.WriteLineColor("------------", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("Hash to Text", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("------------", ConsoleColor.Yellow);

                        ColorText.WriteColor("\nHash: ", ConsoleColor.Cyan);

                        string input2 = ColorText.ReadLineColor(ConsoleColor.Yellow);

                        var output2 = Functions.UnhashString(input2);

                        ColorText.WriteColor($"\nText:", ConsoleColor.Cyan);
                        ColorText.WriteLineColor(output2, ConsoleColor.Yellow);

                        ColorText.WriteLineColor("\nPress any button to go back to main menu", ConsoleColor.Cyan);

                        ColorText.ReadKeyColor(ConsoleColor.Yellow);

                        break;

                    default:
                        
                        return;

                }

            }

            void Binary() {

                Console.Clear();

                ColorText.WriteLineColor("------", ConsoleColor.Yellow);
                ColorText.WriteLineColor("Binary", ConsoleColor.Yellow);
                ColorText.WriteLineColor("------", ConsoleColor.Yellow);
                
                ColorText.WriteColor("\n1", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Text to Binary", ConsoleColor.Cyan);
                ColorText.WriteColor("2", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Binary to Text\n", ConsoleColor.Cyan);

                int decision2 = Convert.ToInt32(ColorText.ReadLineColor(ConsoleColor.Yellow));

                switch (decision2) {

                    case 1:

                        Console.Clear();

                        ColorText.WriteLineColor("--------------", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("Text to Binary", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("--------------", ConsoleColor.Yellow);

                        ColorText.WriteColor("\nText: ", ConsoleColor.Cyan);

                        string input1 = ColorText.ReadLineColor(ConsoleColor.Yellow);

                        var output1 = Functions.StringToBinary(input1);

                        ColorText.WriteColor($"\nBinary: ", ConsoleColor.Cyan);
                        ColorText.WriteLineColor(output1, ConsoleColor.Yellow);

                        ColorText.WriteLineColor("\nPress any button to go back to main menu", ConsoleColor.Cyan);

                        ColorText.ReadKeyColor(ConsoleColor.Yellow);

                        break;
                        
                    case 2:

                        Console.Clear();

                        ColorText.WriteLineColor("--------------", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("Binary to Text", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("--------------", ConsoleColor.Yellow);

                        ColorText.WriteColor("\nBinary: ", ConsoleColor.Cyan);

                        string input2 = ColorText.ReadLineColor(ConsoleColor.Yellow);

                        var output2 = Functions.BinaryToString(input2);

                        ColorText.WriteColor($"\nText: ", ConsoleColor.Cyan);
                        ColorText.WriteLineColor(output2, ConsoleColor.Yellow);

                        ColorText.WriteLineColor("\nPress any button to go back to main menu", ConsoleColor.Cyan);

                        ColorText.ReadKeyColor(ConsoleColor.Yellow);

                        break;
                        
                    default:
                        
                        return;

                }

            }

            void Hexadecimal() {

                Console.Clear();

                ColorText.WriteLineColor("-----------", ConsoleColor.Yellow);
                ColorText.WriteLineColor("Hexadecimal", ConsoleColor.Yellow);
                ColorText.WriteLineColor("-----------", ConsoleColor.Yellow);

                ColorText.WriteColor("\n1", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Text to Hexadecimal", ConsoleColor.Cyan);
                ColorText.WriteColor("2", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Hexadecimal to Text\n", ConsoleColor.Cyan);

                int decision2 = Convert.ToInt32(ColorText.ReadLineColor(ConsoleColor.Yellow));

                switch (decision2) {

                    case 1:

                        Console.Clear();

                        ColorText.WriteLineColor("-------------------", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("Text to Hexadecimal", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("-------------------", ConsoleColor.Yellow);

                        ColorText.WriteColor("\nText: ", ConsoleColor.Cyan);

                        string input1 = ColorText.ReadLineColor(ConsoleColor.Yellow);

                        var output1 = Functions.StringToHex(input1);

                        ColorText.WriteColor($"\nHex: ", ConsoleColor.Cyan);
                        ColorText.WriteLineColor(output1, ConsoleColor.Yellow);

                        ColorText.WriteLineColor("\nPress any button to go back to main menu", ConsoleColor.Cyan);

                        ColorText.ReadKeyColor(ConsoleColor.Yellow);

                        break;
                        
                    case 2:

                        Console.Clear();

                        ColorText.WriteLineColor("-------------------", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("Hexadecimal to Text", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("-------------------", ConsoleColor.Yellow);

                        ColorText.WriteColor("\nHex: ", ConsoleColor.Cyan);

                        string input2 = ColorText.ReadLineColor(ConsoleColor.Yellow);

                        var output2 = Functions.HexToString(input2);

                        ColorText.WriteColor($"\nText: ", ConsoleColor.Cyan);
                        ColorText.WriteLineColor(output2, ConsoleColor.Yellow);

                        ColorText.WriteLineColor("\nPress any button to go back to main menu", ConsoleColor.Cyan);

                        ColorText.ReadKeyColor(ConsoleColor.Yellow);

                        break;
                        
                    default:
                        
                        return;

                }

            }

            void MorseCode() {

                ColorText.WriteLineColor("To be added...",  ConsoleColor.White);

                ColorText.ReadKeyColor(ConsoleColor.Yellow);

            }

        }

    }

}
