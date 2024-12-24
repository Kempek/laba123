using System;

namespace OrderCalculatorLibrary
{
    public class OrderCalculator
    {
        public static double CalculateTotalOrderCost(double unitPrice, int quantity, double discount)
        {
            return unitPrice * quantity * (1 - discount);
        }
    }
}