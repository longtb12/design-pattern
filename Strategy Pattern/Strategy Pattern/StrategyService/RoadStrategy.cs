using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.StrategyService
{
    public class RoadStrategy : INavigatorStrategy
    {
        public void buildRoute(string Source, string Dest)
        {
            Console.WriteLine("I am going to " + Dest + " from " + Source + " by Road");
        }
    }
}
