using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Game
{
    class TransportComparer : IComparer<Transport>
    {
        private Func<Transport, Transport, int> compFunc;

        public TransportComparer(Func<Transport, Transport, int> comp)
        {
            compFunc = comp;
        }

        public int Compare(Transport x, Transport y)
        {
            return compFunc(x, y);
        }
    }
}
