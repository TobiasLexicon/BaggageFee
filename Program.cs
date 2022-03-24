using System;
using static System.Console;

namespace BaggageFee
{
    static class Program
    {
        // Check in

        // weigh baggage
        // calculate excess
        // allowance 12 kg
        // calculate fee
        // feePerKilo 5 $

        static void Main(string[] args)
        {
            int weight = checkBaggage();
            int excessWeight = getExcessWeight(weight);
            int feeToPay = computeAdditionalFee(excessWeight);

            int additionalFee2 = computeAdditionalFee(getExcessWeight(checkBaggage()));

            int additionalFee = checkBaggage()
                .getExcessWeight()
                .computeAdditionalFee();
                

            WriteLine($"You have to pay {feeToPay}$ in baggage fee");
            ReadKey();


 
        }

        public static int checkBaggage()
        {
            int registeredWeight = 0;
            bool validInput = false;
            while (validInput == false)
            {
                WriteLine("Register your baggage (in kg)");
                validInput = int.TryParse(ReadLine(), out registeredWeight);
            }
            return registeredWeight;
        }

        public static int getExcessWeight(this int registeredWeight)
        {
            int excessWeight = 0;
            int allowedWeight = 12;
            if(registeredWeight > allowedWeight)
            {
                excessWeight = registeredWeight - allowedWeight;
            }
            return excessWeight;
        }

        public static int computeAdditionalFee(this int excessWeight)
        {
            int additionalFee = 36;
            int feePerKilo = 5;
            additionalFee += excessWeight * feePerKilo;
            return additionalFee;
        }
    }
}
