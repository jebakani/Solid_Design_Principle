using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    /// if we implement the Calculate fare class if we create object it does not get execute 
    /// so we can create an abstrat class that has method that can be overide
    /// </summary>
    public abstract class  Fare
    {
        public abstract double CalculateFare(double distance, int time);

    }
    //if we wat to calculate comman fare
    class CalculateFares : Fare
    {
        public override double CalculateFare(double distance, int time)
        {
            double fare = distance * 10 + time * 1;
            return fare;
        }
    }
    //adding new class called premium ride which extends tha calculate fare class
    class PremiumFare : Fare
    {
        public override double CalculateFare(double distance, int time)
        {
            double fare = distance * 30 + time * 10;
            return fare;
        }
    }
    //adding new class called normal ride which extends tha calculate fare class
    class NormalFare : Fare
    {
        public override double CalculateFare(double distance, int time)
        {
            double fare = distance * 20 + time * 5;
            return fare;
        }
    }
}
