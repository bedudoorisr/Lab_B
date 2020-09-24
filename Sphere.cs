using System;


namespace GeometricFigureHandler
{
    public class Sphere : Shape3D
    {
        private const float Pi = (float)Math.PI;
        private readonly float myRadius;

        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            myRadius = radius;
        }

        public override Vector3 Center { get; }
        public override float Area => 4 * Pi * (float)Math.Pow(myRadius, 2);
        public override float Volume => 4 * Pi * (float)Math.Pow(myRadius, 3) / 3;

        public override string ToString()
        {
            return $"Circle @ ({Center.X:N1},{Center.Y:N1}): r={myRadius:N1}";
        }
    }
}