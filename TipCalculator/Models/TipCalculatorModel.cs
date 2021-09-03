using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        //Simple error validation output for the cost of meal, 
        [Required (ErrorMessage = "Please input a cost of meal.")]
        [Range(1,int.MaxValue, ErrorMessage ="Please input a positive cost of meal.")]
        public decimal? COM { get; set; }

        //Cost of meal 15%-20%-25% tip functions.
        public decimal? Calculate15Tip()
        {
            decimal? tip1 = COM * (decimal)1.15;
            return tip1;
        }

        public decimal? Calculate20Tip()
        {
            decimal? tip2 = COM * (decimal)1.20;
            return tip2;
        }
        public decimal? Calculate25Tip()
        {
            decimal? tip3 = COM * (decimal)1.25;
            return tip3;
        }
    }
}
