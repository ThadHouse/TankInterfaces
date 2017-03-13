using System;
using System.Collections.Generic;

namespace XNATankGame
{
    public struct NetworkPoint : IPoint, IEquatable<NetworkPoint>
    {
        public int X { get; }
        public int Y { get; }

        public NetworkPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(NetworkPoint other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is NetworkPoint && Equals((NetworkPoint)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }

        public static bool operator ==(NetworkPoint left, NetworkPoint right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(NetworkPoint left, NetworkPoint right)
        {
            return !left.Equals(right);
        }

        private sealed class XYEqualityComparer : IEqualityComparer<NetworkPoint>
        {
            public bool Equals(NetworkPoint x, NetworkPoint y)
            {
                return x.X == y.X && x.Y == y.Y;
            }

            public int GetHashCode(NetworkPoint obj)
            {
                unchecked
                {
                    return (obj.X * 397) ^ obj.Y;
                }
            }
        }

        public static IEqualityComparer<NetworkPoint> XYComparer { get; } = new XYEqualityComparer();
    }
}
