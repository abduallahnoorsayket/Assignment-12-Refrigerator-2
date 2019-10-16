using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
   class Refrigarator
    {
        private double MaxWeight;
      

        public Refrigarator (double maxweight)
        {
            this.MaxWeight = maxweight;
        }
        
      public  List<int> NoItems = new List<int>();
          public int NoItem {  set; get; }
        //public int NoItem { private get; set; }

     public   List<double> UnitWeights = new List<double>();
        public double UnitWeight { set; get; }


        public List<double> Total = new List<double>();

         public bool OverFlow(int NoOFItem, double WeightPerItem)
         {
             bool isOverFlow = false;
             double newWeight = (NoOFItem * WeightPerItem);
             double newCurrentWeight = GetCurrentWeight() + newWeight;
             if (newCurrentWeight <= GetCurrentWeight() && GetCurrentWeight() !=0 && newCurrentWeight<= MaxWeight)
             {
                 isOverFlow = true;
             }

            return isOverFlow;
         }
        

        public void  Add (int NoItem , double UnitWeight)
        {
         
           NoItems.Add(this.NoItem);
            UnitWeights.Add(this.UnitWeight);
        }

       public double  GetCurrentWeight()
        {
            double CurrentWeight = 0.0;
            for(int i=0; i< NoItems.Count(); i++ )
            {
                CurrentWeight += NoItems[i] * UnitWeights[i];
               
            }
            return CurrentWeight;
        }

     public double GetRemainingWeight()
        {
            double RemainingWeight=this.MaxWeight - GetCurrentWeight();

            return RemainingWeight;
        }

    }
}
