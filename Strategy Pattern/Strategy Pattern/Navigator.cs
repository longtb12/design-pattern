using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Navigator
    {
        private INavigatorStrategy _strategy;

        public Navigator()
        {
        }

        public Navigator(INavigatorStrategy strategy)
        {
            _strategy = strategy;
        }

        public void setNavigator(INavigatorStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Go(string Source, string Dest)
        {
            _strategy.buildRoute(Source, Dest);
        }
    }
}
