using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    interface IDirection
    {
        void Step(ref int X, ref int Y);
        IDirection ChangeTrend(string command);
        direction Trend { get; }

    }
}
