using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        //static datatypes so i can use it within the static main
        //i didnt include the private acceess modifier since i'm not using another method, unlike the previous lab exercise i made, i have instance variables there. :)
        static int pieces;
        static double price;
        static void Main(string[] args)
        {
            //boolean so i can use it for the while loop in order to loop if the input is in incorrect format, like string or characters
            bool flag = false;

            //if flag is still false, it will continue looping, and if it turns true, it will end the program stop looping           
            while (!flag) {
                //i did exception handling here so if the inputs are not in the right format, it will call a message that the input is invalid
                try
                {
                    //INPUTS FOR PIECES AND PRICE
                    Console.Write("Enter the pieces of banana: ");
                    pieces = Convert.ToInt32(Console.ReadLine());

                    //i added the syntax  (counter > 1 ? "s" : ""), bc i just noticed that we are talking about how "many" here.
                    //and yeah as i noticed, i remembered something, a good friend of mine (chauncy, props to you) taught me this Java syntax before, and i just found out that it also works in C#, pretty cool :) 
                    //i made a counter integer so it counts the total of pieces from the integer pieces, therefore if the counter is more than 1, it adds "s" to the banana, and if not, it wont.

                    int counter = pieces;                 
                    Console.Write("Enter total price of " + counter + " banana" + (counter > 1 ? "s" : "") + ": ");
                    price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("The total price of " + pieces + " banana" + (counter > 1 ? "s" : "") + " is " + price);

                    //CONVERSION OF DATATYPES OR ALSO CALLED TYPE CASTING
                    //from double to int
                    int newPrice = (int)price;
                    Console.WriteLine("The value of original price is " + price);
                    Console.WriteLine("The value of converted price is " + newPrice);

                    //here we go, the flag will be true, and the loop will stop
                    flag = true;

                }
                //exception for incorrect format
                catch (FormatException e)
                {
                    //the message i just mentioned
                    Console.WriteLine("Invalid Input. Please Try Again!");
                    //spacing
                    Console.WriteLine();
                    //continue looping if yun nga the input is incorrect format :)
                    continue;
                }    
            }
        }
    }
}
