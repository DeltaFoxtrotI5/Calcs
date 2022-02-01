using System;

namespace Calcs
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            //First Calc

            Calculators TexasI = new Calculators("JakesCalc", "Fucia", "Lightish Red", 6, 2, 17, true, false, 2, "Eng");
            //Console.WriteLine(TexasI.Name + " Is " + TexasI.Color + " With a " + TexasI.CoverColor + " Cover.");
            //Console.WriteLine(TexasI.AmountBattries +" Batteries "+ TexasI.PercentOfBattery +"%"+ " is active " + TexasI.IsActive + " is solar " + TexasI.IsSolar);

            Calculators RileyCalc = new Calculators("Riley's Calculator", "Black", "Black", 50, 2, 2, false, false, 2, "Texas Instruments");


            TexasI.Describe();
            TexasI.Describe2();
            TexasI.AddTime();
            TexasI.AddTime();
            TexasI.AddTime();
            TexasI.AddTime();
            TexasI.Describe();
            TexasI.Describe2();
            TexasI.AddTime();
            TexasI.AddTime();
            TexasI.AddTime();
            TexasI.Describe();
            TexasI.Describe2();

            RileyCalc.Describe();
            RileyCalc.Describe2();
            RileyCalc.AddTime();
            RileyCalc.AddTime();
            RileyCalc.Describe();
            RileyCalc.Describe2();


















        }
    }
}
