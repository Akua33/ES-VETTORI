using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_VETTORI
{
    public class Vector
    {
        public readonly double X;
        public readonly double Y; 
        public Vector(double x, double y)    
        {
            X = x;
            Y = y;  
        }
        public static double Modulo (Vector v1)
        {
            return Math.Sqrt((v1.X * v1.X)+( v1.Y * v1.Y));

        }
        public static Vector operator +(Vector v1, Vector v2) 
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y); 

        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);

        }

        public static Vector operator *(Vector v1, Vector v2) 
        {
            return new Vector(v1.X * v2.X, v1.Y * v2.Y);
        
        }

        public static Vector operator *(Vector v1, double s)
        {
            return new Vector(v1.X * s, v1.Y * s);

        }

        public static Vector operator *(double s, Vector v1)
        {
            return new Vector(s*v1.X, s*v1.Y);

        }

        public static Vector operator /(Vector v1, double s)
        {
            return new Vector(v1.X /s, v1.Y / s);

        }
        public static Vector operator +(Vector v1)
        {
            return new Vector(+v1.X, + v1.Y );

        }
        public static Vector operator -(Vector v1)
        {
            return new Vector(-v1.X, -v1.Y);

        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }




    }
}
