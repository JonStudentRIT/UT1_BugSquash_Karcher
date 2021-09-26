using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            // Compiler Error, missing semicolon
            //int nY
            int nY = 0;
            int nAnswer;
            // Compiler Error, missing quotation marks
            //Console.WriteLine(This program calculates x ^ y.);
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Logical Error, readline is not assigning to a variable
                //Console.ReadLine();
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            // Logical Error, Ny is the variable referenced by the display to the user
            //} while (int.TryParse(sNumber, out nX));
            } while (!int.TryParse(sNumber, out nY));

            // compute the factorial of the number using a recursive function
            nAnswer = Power(nX, nY);
            // Logical Error, the output doesnt display the input or the answer
            //Console.WriteLine("{nX}^{nY} = {nAnswer}"); 
            Console.WriteLine("{0}^{1} = {2}", nX,nY,nAnswer);
        }

        // Compiler Error, since the Main is static then the method needs to be static as well
        //int Power(int nBase, int nExponent) 
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                // Logical Error, the base case multiplys the answer by 0
                //returnVal = 0; 
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                // Runtime Error, the recursive loop incraments when the base case is meant to decrease
                //nextVal = Power(nBase, nExponent + 1); 
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }
            // Compiler Error, the function dosnt return a final value
            //returnVal; 
            return returnVal;
        }
    }
}
