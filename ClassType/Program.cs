using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

namespace ClassType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Class Type".DumpAsTitle();

            "Formally, a class user-defined type that is composed of field data and members that operate on this data".Dump();

            "For an example check WaterTank class".Dump();

            WaterTank waterTank = new();

            for (int i =0; i < 25; i++)
            {
                decimal overflowAmount = waterTank.Fill(i);
                $"Overflow Amount : {overflowAmount}".Dump();
                waterTank.PrintCurrentState();
                ConsoleHelper.Seperate();
            }

            "Objects must be allocated into memory using the new keyword".Dump();


            // We can allocate with single line 
            WaterTank waterTank1 = new();

            // Or in seperated lines
            WaterTank waterTank2; // deafult value is null

            $"waterTank2 is null at the begining".Dump();

            waterTank2 = new();
        }

        class WaterTank
        {
            // State of the WaterTank
            public decimal MaxCapacity = 100;
            public decimal CurrentValue = 0;
            public decimal PercentageOfFullness = 0;


            // Functionality of the WaterTank
            public decimal Fill(decimal amount)
            {
                decimal overflowAmount = 0;
                CurrentValue += amount;

                if (CurrentValue > MaxCapacity)
                {
                    overflowAmount = Math.Abs(MaxCapacity - CurrentValue);
                    CurrentValue = MaxCapacity;
                    PercentageOfFullness = 100;
                }
                else if (CurrentValue == MaxCapacity)
                {
                    CurrentValue = MaxCapacity;
                    PercentageOfFullness = 100;
                }
                else
                {
                    PercentageOfFullness = CurrentValue;
                }


                return overflowAmount;
            }

            public void Drain()
            {
                CurrentValue = 0;
                PercentageOfFullness = 0;
            }

            public void PrintCurrentState()
            {
                $"{nameof(MaxCapacity)}:{MaxCapacity}".Dump();
                $"{nameof(CurrentValue)}:{CurrentValue}".Dump();
                $"{nameof(PercentageOfFullness)}:{PercentageOfFullness}".Dump();
            }
        }
    }
}
