﻿namespace RefactoringToPatterns.Strategy.Step4.Strategy
{
    internal class EducationMaterialCostCalculationStrategy : WishListItemCostCalculationStrategy
    {
        public override decimal CalculateCost(WishListItem item)
        {
            var totalCost = item.ItemCost;

            if (item.VendorsWithDiscounts.ContainsKey(item.VendorName))
            {
                var discountAmount = totalCost * item.VendorsWithDiscounts[item.VendorName];
                totalCost -= discountAmount;
            }

            return totalCost;
        }
    }
}