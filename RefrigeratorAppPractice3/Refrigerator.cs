using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {

        //private int maxWeight;
        //private  int numberOfItems;
        //private int itemWeightPerUnit;

        public double MaxWeight
        {
            get; set;
        }
        public double NumberOfItem
        {
            set; get;
        }
        public int WeightPerItem
        {
            set; get;
        }
        //public int NumberOfItems { get; set; }
        //public double WeightPerItem { get; set; }

        List<double> NumberOfItems = new List<double>();
        List<double> WeightPerUnit = new List<double>();

        public void SetNumberOfItem()
        {
            NumberOfItems.Add(NumberOfItem);
        }

        public void SetWeightPerItem()
        {
            WeightPerUnit.Add(WeightPerItem);
        }

        

        public double GetCurrentWeight()
        {
            double currentWeight = 0;


            for (int i = 0; i < NumberOfItems.Count; i++)
            {
                
                currentWeight += NumberOfItems[i] * WeightPerUnit[i];
            } 
            
            return currentWeight;
        }

        public bool isPossible(double currentWeight)
        {
            bool isPossible = false;

            if ((this.MaxWeight - currentWeight) >= 0)
            {
                isPossible = true;
            }

            return isPossible;
        }

        public double GetRemainingtWeight(double currentWeight)
        {
            double remainingWeight = 0;            
            return  remainingWeight = this.MaxWeight - currentWeight;               
           
        }
    }
}
