using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNATankGame
{
    public struct Tank : ITank, IEquatable<Tank>
    {
        public double Angle { get; }
        public int X { get; }
        public int Y { get; }
        public NetworkPoint[] Vertices { get; }

        public Tank(double angle, int x, int y, NetworkPoint[] vertices)
        {
            Angle = angle;
            X = x;
            Y = y;
            Vertices = vertices;
        }

        public bool Equals(Tank other)
        {
            return Angle.Equals(other.Angle) && X == other.X && Y == other.Y && Equals(Vertices, other.Vertices);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Tank && Equals((Tank)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Angle.GetHashCode();
                hashCode = (hashCode * 397) ^ X;
                hashCode = (hashCode * 397) ^ Y;
                hashCode = (hashCode * 397) ^ (Vertices != null ? Vertices.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(Tank left, Tank right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Tank left, Tank right)
        {
            return !left.Equals(right);
        }
    }
}
