using System;
using System.Collections.Generic;
using System.Text;

namespace Calcs
{
    public class Calculators
    {
        public string Name;
        public string Color;
        public string CoverColor;
        public float PercentOfBattery;
        public float Weight;
        public int NumberOfColors;
        public bool IsActive;
        public bool IsSolar;
        public int AmountBattries;
        public string TypeOfCalc;
        //Constructor



        public Calculators()
        {

        }

        public Calculators(string name, string color, string coverColor, float percentOfBattery, float weight, int numberOfColors, bool isActive, bool isSolar, int amountBattries, string typeOfCalc)
        {
            Name = name;
            Color = color;
            CoverColor = coverColor;
            PercentOfBattery = percentOfBattery;
            Weight = weight;
            NumberOfColors = numberOfColors;
            IsActive = isActive;
            IsSolar = isSolar;
            AmountBattries = amountBattries;
            TypeOfCalc = typeOfCalc;
        }

        //Methods
        public void Describe()
        {
            Console.WriteLine("\nCalc Name: " + Name);
            Console.WriteLine("\nPercent Of Battry: " + PercentOfBattery + "%");
            Console.WriteLine(" ");




        }
        //Method 2
        public void Describe2()
        {
            Console.WriteLine("\tType Of calc: " + TypeOfCalc);
            Console.WriteLine("\tIs Active: " + IsActive);
        }

        //Method 3
        public void AddTime()
        {
            Console.WriteLine("Time Passes...");
            if (PercentOfBattery <= 0)
            {
                IsActive = false;
            }
            if (IsActive == true)
            {
                PercentOfBattery--;
            }
        }






    }







}
