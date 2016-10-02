using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prax1
{
    class Program
    {
        static void Main(string[] args)
        {

            //programMenu();
            MotorVehicleTest test = new MotorVehicleTest();

        }


        static double getUserInputNumber ()
        {

            string answer = Console.ReadLine();
            double a;

            if (double.TryParse(answer, out a)) // ==true not necessary
            {
                return a;
            }
            else
            {
                Console.WriteLine("please enter a number");
                return getUserInputNumber();
            }
         
        }

        static void getUserInputNumberDialog()
        {
            Console.WriteLine("Enter a number");
            double userInput = getUserInputNumber();
            Console.WriteLine("Entered number was " + userInput);
            Console.WriteLine();
        }

        // Luua meetod fahrenheitToKelvin, mis võtab sisendiks temperatuuri fahrenheitides ja tagastab selle Kelvinities
        static double fahrenheitToKelvin(double inputTemperature)
        {
            return (inputTemperature + 459.67) * 5 / 9;
        }

        static void fahrenheitToKelvinDialog()
        {
            Console.WriteLine("Enter the temperature in Fahrenheit");
            double userInput = getUserInputNumber();
            Console.WriteLine("The temperature in Kelvins is " + fahrenheitToKelvin(userInput));
            Console.WriteLine();
        }


        // Luua meetod celsiusToFahrenheit, mis võtab sisendiks temperatuuri kraadides ja tagastab fahrenheitides.
        static double celsiusToFarenheit(double inputTemperature)
        {
            return inputTemperature * 9 / 5 + 32;
        }

        static void celsiusToFahrenheitDialog()
        {
            Console.WriteLine("Enter the temperature in Celsius");
            double userInput = getUserInputNumber();
            Console.WriteLine("The temperature in Fahrenheit is " + celsiusToFarenheit(userInput));
            Console.WriteLine();
        }

        // Luua meetod, mis tagastab vastavalt kasutaja vanusele, kas tegemist on täisealise kasutajaga või mitte
        static bool isAdult(double userInput)
        {
            return userInput >= 18;
        }

        static void isAdultDialog()
        {
            Console.WriteLine("Enter your age");
            double userInput = getUserInputNumber();

            if (isAdult(userInput)) {
                Console.WriteLine("Your an adult, get a job");
            }
            else
            {
                Console.WriteLine("Get back to school, kid");
            }
            Console.WriteLine();
        }


        // Luua meetod, mis saab sisendiks kolm arvu, mis on kolmnurga külgede pikkused, ja tagastab kas tegemist on kolmnurgaga

        static bool isTriangle (double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0) return false;
            if ((side1 >= side2 + side3) || (side2 >= side1 + side3) || (side3 >= side1 + side2)) return false;

            return true;
        }

        static void isTriangleDialog()
        {
            Console.WriteLine("Enter the length of side 1");
            double side1 = getUserInputNumber();
            Console.WriteLine("Enter the length of side 2");
            double side2 = getUserInputNumber();
            Console.WriteLine("Enter the length of side 3");
            double side3 = getUserInputNumber();

            if (isTriangle(side1, side2, side3))
            {
                Console.WriteLine("This could totally be a triangle");
            }
            else
            {
                Console.WriteLine("A triangle this is not");
            }
            Console.WriteLine();

        }

        static int countWords(String inputString)
        {

            int answer = 0;

            if (inputString.Length > 0) answer = 1;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ') answer++;
            }

            return answer;
        }

        static void countWordsDialog()
        {
            Console.WriteLine("Enter a sentence, I'll count the words");
            String userInput = Console.ReadLine();
            Console.WriteLine("number of words: " + countWords(userInput));
            Console.WriteLine();
        }


        static String reverseString(String inputString)
        {
            String answer = "";

            for (int i = inputString.Length - 1; i > -1; i--)
            {
                answer += inputString[i];
            }


            return answer;
        }

        static void reverseStringDialog()
        {
            Console.WriteLine("Enter a string, I'll reverse it");
            String userInput = Console.ReadLine();
            Console.WriteLine("reversed string: \"" + reverseString(userInput) + "\"");
            Console.WriteLine();
        }



        static void programMenu()
        {

            Console.WriteLine("Enter option number to select what you want to do");
            Console.WriteLine("0. exit program");
            Console.WriteLine("1. isNumber");
            Console.WriteLine("2. fahrenheitToKelvin");
            Console.WriteLine("3. celsiusToFahrenheit");
            Console.WriteLine("4. isAdult");
            Console.WriteLine("5. isTriangle");
            Console.WriteLine("6. countWords");
            Console.WriteLine("7. reverseString");
            Console.WriteLine("8. run Rectangle class tests");
            Console.WriteLine("9. run Point class tests");
            Console.WriteLine("10. run ComplexNumber class tests");
            Console.WriteLine("11. run MotorVehicle, Car and DumpTruck class test");


            String userChoice = Console.ReadLine();

            Console.WriteLine();

            switch (userChoice)
            {
                case "0":
                    break;
                case "1":
                    getUserInputNumberDialog();
                    programMenu();
                    break;
                case "2":
                    fahrenheitToKelvinDialog();
                    programMenu();
                    break;
                case "3":
                    celsiusToFahrenheitDialog();
                    programMenu();
                    break;
                case "4":
                    isAdultDialog();
                    programMenu();
                    break;
                case "5":
                    isTriangleDialog();
                    programMenu();
                    break;
                case "6":
                    countWordsDialog();
                    programMenu();
                    break;
                case "7":
                    reverseStringDialog();
                    programMenu();
                    break;
                case "8":
                    RectangleTest testR = new RectangleTest();
                    Console.WriteLine();
                    programMenu();
                    break;
                case "9":
                    PointTest testP = new PointTest();
                    Console.WriteLine();
                    programMenu();
                    break;
                case "10":
                    ComplexNumberTest testC = new ComplexNumberTest();
                    Console.WriteLine();
                    break;
                case "11":
                    MotorVehicleTest testM = new MotorVehicleTest();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Please enter a valid option number");
                    programMenu();
                    break;
            }
        }

    }
}
