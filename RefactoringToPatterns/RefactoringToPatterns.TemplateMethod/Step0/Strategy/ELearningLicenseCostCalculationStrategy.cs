﻿namespace RefactoringToPatterns.TemplateMethod.Step0.Strategy
{
    internal class ELearningLicenseCostCalculationStrategy : WishListItemCostCalculationStrategy
    {
        internal override decimal CalculateCost(WishListItem item)
        {
            var totalCost = item.ItemCost;

            var duration = item.EndDate - item.StartDate;

            if (duration.HasValue && duration.Value.Days > 180)
            {
                totalCost *= 0.8m;
            }

            return totalCost;
        }
    }
}