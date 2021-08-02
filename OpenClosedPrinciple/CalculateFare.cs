using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    /// <summary>
    /// here the program is open for extention that is if any new type of ride is created in future 
    /// we can extend the calculate fare class to calculate the fare 
    /// premium and normal ride does not get modified
    /// </summary>
    class CalculateFare
    {
        public virtual double CalculateFair(double distance,int time)
        {
            double fare = distance * 10 + time * 1;
            return fare;
        }
    }
    //adding new class called premium ride which extends tha calculate fare class
    class PremiumFare :CalculateFare
    {
        public override double CalculateFair(double distance, int time)
        {
            double fare = distance * 30 + time * 10;
            return fare;
        }
    }
    //adding new class called normal ride which extends tha calculate fare class
    class NormalFare :CalculateFare
    {
        public override double CalculateFair(double distance, int time)
        {
            double fare = distance * 20 + time * 5;
            return fare;
        }
    }
}
