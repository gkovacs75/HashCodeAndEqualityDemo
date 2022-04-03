using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCodeDemo
{
    public class PointA : IEquatable<PointA>
    {
        public int X { get; init; }
        public int Y { get; init; }

        public PointA(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool Equals(PointA? other)
        {
            Console.Write(" Calling Equals(PointA? other): ");

            return other != null && this.GetType() == other.GetType() && other.X == this.X && other.Y == this.Y;
        }

        public override bool Equals(object obj)
        {            
            Console.Write(" Calling Equals(object obj): ");

            return Equals(obj as PointA);
        }

        public override int GetHashCode()
        {            
            // When comparing 2 objects, the system will use a hash table to see if 2 objects 
            // have the same hashcode. This is much faster than calling .Equals() over and over.
            // Once a match is found (2 objects have the same hashcode), then the system will 
            // call .Equals() just to be sure that they are in fact the same object. This is because
            // 2 objects could have the same hash code. Since ints are 32 bits in .net, that means 
            // that we have 2^32 possible hash codes--about 4 billion. 

            Console.Write(" Calling GetHashCode(): ");

            // HashCode allows you to combine up to 8 elements
            return HashCode.Combine(this.X, this.Y);

            // If you have more than 8 items, do the following:
            // HashCode hc = new HashCode();
            // hc.Add(this.X);
            // hc.Add(this.Y);
            // etc...
            // return hc.ToHashCode();
        }
    }
}
