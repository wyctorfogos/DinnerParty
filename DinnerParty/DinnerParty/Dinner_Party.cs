using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party
{
    class DinnerParty
    {
        private const int CostOfFoodPerPerson = 25;
        private int numberofpeople;
        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations;

        public int Numberofpeople { get => numberofpeople; }

        public void SetNumberOfPeople(int NewNumberofPeople)
        {
            numberofpeople = NewNumberofPeople;
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }
        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (numberofpeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (numberofpeople * 7.50M) + 30M;
            }
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * numberofpeople);
            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
