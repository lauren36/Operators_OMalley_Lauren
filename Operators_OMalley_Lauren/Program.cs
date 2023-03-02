using System;

namespace Operators_OMalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTEGERS");
            // Initialized an integer that multipies two integers
            int intMult = 6 * 45;

            // Initialized an integer that adds two integers
            int intAdd = 55 + 66;

            // Shows the maximum and the minimum of the two integer variables
            Console.WriteLine($"The maximum of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}." +
                $"The minimum of the two is {Math.Min(intMult, intAdd)}");

            // Initializes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;

            // Shows if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.\n");


            Console.WriteLine("SHORTS");
            // Initialized an short that multipies two shorts
            short shortMult = 6 * 45;

            // Initialized an short that adds two shorts
            short shortAdd = 55 + 66;

            // Shows the maximum and the minimum of the two short variables
            Console.WriteLine($"The maximum of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}." +
                $"The minimum of the two is {Math.Min(shortMult, shortAdd)}");

            // Initializes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;

            // Shows if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.\n");


            Console.WriteLine("LONGS");
            // Initialized an long that multipies two long
            long longMult = 6 * 45;

            // Initialized an long that adds two long
            long longAdd = 55 + 66;

            // Shows the maximum and the minimum of the two long variables
            Console.WriteLine($"The maximum of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}." +
                $"The minimum of the two is {Math.Min(longMult, longAdd)}");

            // Initializes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;

            // Shows if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.\n");



            Console.WriteLine("FLOATS");
            // Initialized an float that multipies two float
            float floatMult = 6.5f * 45.24f;

            // Initialized an float that adds two float
            float floatAdd = 55.35f + 66.15f;

            // Shows the maximum and the minimum of the two float variables
            Console.WriteLine($"The maximum of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}." +
                $"The minimum of the two is {Math.Min(floatMult, floatAdd)}");

            // Initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;

            // Shows if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.\n");



            Console.WriteLine("DOUBLES");
            // Initialized an double that multipies two double
            double doubleMult = 6.69 * 45.58;

            // Initialized an double that adds two double
            double doubleAdd = 55.48 + 66.15;

            // Shows the maximum and the minimum of the two double variables
            Console.WriteLine($"The maximum of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}." +
                $"The minimum of the two is {Math.Min(doubleMult, doubleAdd)}");

            // Initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;

            // Shows if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.\n");



            Console.WriteLine("DECIALS");
            // Initialized an decimal that multipies two decimal
            decimal decimalMult = (decimal)(6.25 * 45.15);

            // Initialized an decimal that adds two decimal
            decimal decimalAdd = (decimal)(55.66 + 66.55);

            // Shows the maximum and the minimum of the two decimal variables
            Console.WriteLine($"The maximum of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}." +
                $"The minimum of the two is {Math.Min(decimalMult, decimalAdd)}");

            // Initializes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;

            // Shows if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.\n");
        }
    }
}
