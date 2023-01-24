using System;
using System.IO;
using System.Text;

namespace Converter {
    
    public class Program {

        public static int GetUserInput(int minValue, int maxValue) {

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            while (true) {

                if (char.IsDigit(keyInfo.KeyChar)) {

                    int input = int.Parse(keyInfo.KeyChar.ToString());

                    if (input < minValue || input > maxValue) {

                        Console.Write("\r"); // Removes the user input from the console

                        ColorText.WriteLineColor($"Please enter a number between {minValue} and {maxValue}", ConsoleColor.Red);

                        keyInfo = Console.ReadKey();

                        continue;

                    }

                    return input;
                    
                }

                Console.Write("\r"); // Removes the user input from the console

                ColorText.WriteLineColor("Please enter a valid number", ConsoleColor.Red);

                keyInfo = Console.ReadKey();

            }

        }

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

                int input = GetUserInput(0, 4);

                switch (input) {

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
                ColorText.WriteLineColor(" - Text to Hash", ConsoleColor.Cyan);
                ColorText.WriteColor("2", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Hash to Text\n", ConsoleColor.Cyan);

                int input = GetUserInput(1, 2);

                switch (input) {

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

                        ColorText.WriteLineColor("\nPress any key to go back to the main menu\n", ConsoleColor.Cyan);

                        break;
                        
                    case 2:

                        Console.Clear();

                        ColorText.WriteLineColor("------------", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("Hash to Text", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("------------", ConsoleColor.Yellow);

                        ColorText.WriteColor("\nHash: ", ConsoleColor.Cyan);

                        string input2 = ColorText.ReadLineColor(ConsoleColor.Yellow);

                        var output2 = Functions.UnhashString(input2);

                        ColorText.WriteColor($"\nText: ", ConsoleColor.Cyan);
                        ColorText.WriteLineColor(output2, ConsoleColor.Yellow);

                        ColorText.WriteLineColor("\nPress any key to go back to the main menu\n", ConsoleColor.Cyan);

                        break;

                    default:
                        
                        return;

                }

                Console.ReadKey();

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

                int input = GetUserInput(1, 2);

                switch (input) {

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

                        ColorText.WriteLineColor("\nPress any key to go back to the main menu\n", ConsoleColor.Cyan);

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

                        ColorText.WriteLineColor("\nPress any key to go back to the main menu\n", ConsoleColor.Cyan);

                        break;
                        
                    default:
                        
                        return;

                }

                Console.ReadKey();

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

                int input = GetUserInput(1, 2);
                
                switch (input) {

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

                        ColorText.WriteLineColor("\nPress any key to go back to the main menu\n", ConsoleColor.Cyan);

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

                        ColorText.WriteLineColor("\nPress any key to go back to the main menu\n", ConsoleColor.Cyan);

                        break;
                        
                    default:
                        
                        return;

                }

                Console.ReadKey();

            }

            void MorseCode() {

                Console.Clear();

                ColorText.WriteLineColor("----------", ConsoleColor.Yellow);
                ColorText.WriteLineColor("Morse Code", ConsoleColor.Yellow);
                ColorText.WriteLineColor("----------", ConsoleColor.Yellow);

                ColorText.WriteColor("\n1", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Text to Morse", ConsoleColor.Cyan);
                ColorText.WriteColor("2", ConsoleColor.Magenta);
                ColorText.WriteLineColor(" - Morse to Text\n", ConsoleColor.Cyan);

                int input = GetUserInput(1, 2);

                switch (input) {

                    case 1:

                        Console.Clear();

                        ColorText.WriteLineColor("------------------", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("Text to Morse Code", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("------------------", ConsoleColor.Yellow);

                        ColorText.WriteColor("\nText: ", ConsoleColor.Cyan);

                        string input1 = ColorText.ReadLineColor(ConsoleColor.Yellow);

                        var output1 = Functions.StringToMorse(input1);

                        if (output1 != null) {

                            ColorText.WriteColor($"\nMorse: ", ConsoleColor.Cyan);
                            ColorText.WriteLineColor(output1, ConsoleColor.Yellow);
                            
                        }

                        ColorText.WriteLineColor("\nPress any key to go back to the main menu\n", ConsoleColor.Cyan);

                        break;

                    case 2:

                        Console.Clear();

                        ColorText.WriteLineColor("------------------", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("Morse Code to Text", ConsoleColor.Yellow);
                        ColorText.WriteLineColor("------------------", ConsoleColor.Yellow);

                        ColorText.WriteColor("\nMorse: ", ConsoleColor.Cyan);

                        string input2 = ColorText.ReadLineColor(ConsoleColor.Yellow);

                        var output2 = Functions.MorseToString(input2);

                        if (output2 != null) {

                            ColorText.WriteColor($"\nText: ", ConsoleColor.Cyan);
                            ColorText.WriteLineColor(output2, ConsoleColor.Yellow);

                        }

                        ColorText.WriteLineColor("\nPress any key to go back to the main menu\n", ConsoleColor.Cyan);

                        break;

                    default:

                        return;

                }

                Console.ReadKey();

            }

        }

    }

}
