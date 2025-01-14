using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVector2D
{
    internal class Vector2D
    {
        double num1;
        double num2;

        public Vector2D(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double GetNum1()
        {
            return num1;
        }

        public double GetNum2()
        {
            return num2;
        }

        public void SetNum1(double num1)
        {
            this.num1 = num1;
        }

        public void SetNum2(double num2)
        {
            this.num2 = num2;
        }

        public void Sum(Vector2D vector)
        {
            num1 += vector.num1;
            num2 += vector.num2;
        }

        public static Vector2D operator +(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D(vector1.num1 + vector2.num1, vector1.num2 + vector2.num2);
        }

        public override string ToString()
        {
            return $"({num1}, {num2})";
        }
    }
}
