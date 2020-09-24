using System;


namespace GeometricFigureHandler
{
    public class Circle : Shape2D
    {
        private const float Pi = (float) Math.PI;
        private readonly float myRadius;

        public Circle(Vector3 center, float radius)
        {
            Center = new Vector3 {X = center.X, Y = center.Y, Z = 0};
            myRadius = radius;
        }

        public override Vector3 Center { get; }
        public override float Area => Pi * myRadius * myRadius;
        public override float Circumference => Pi * 2 * myRadius;

        public override string ToString()
        {
            return $"Circle @ ({Center.X:N1},{Center.Y:N1}): r = {myRadius:N1}";
        }
    }
}