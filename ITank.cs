using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNATankGame
{
    public interface ITank
    {
        double Angle { get; }
        int X { get; }
        int Y { get; }

        NetworkPoint[] Vertices { get; } 
    }
}
