using System;


namespace GeometricFigureHandler
{
    public class Triangle : Shape2D
    {
        private readonly Vector2 myP1;
        private readonly Vector2 myP2;
        private readonly Vector2 myP3;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            myP1 = p1;
            myP2 = p2;
            myP3 = p3;
        }

        public override Vector3 Center => new Vector3 {X = (myP1.X + myP2.X + myP3.X) / 3, Y = (myP1.Y + myP2.Y + myP3.Y) / 3, Z = 0};
        public override float Area => (myP1.X * (myP2.Y - myP3.Y) + myP2.X * (myP3.Y - myP1.Y) + myP3.X * (myP1.Y - myP2.Y)) / 2;

        public override float Circumference => (float) (Math.Sqrt(Math.Pow(myP2.X - myP1.X, 2) + Math.Pow(myP2.Y - myP1.Y, 2)) +
                                                        Math.Sqrt(Math.Pow(myP3.X - myP2.X, 2) + Math.Pow(myP3.Y - myP2.Y, 2)) +
                                                        Math.Sqrt(Math.Pow(myP1.X - myP3.X, 2) + Math.Pow(myP1.Y - myP3.Y, 2)));

        public override string ToString()
        {
            return
                $"Triangle @ ({Center.X:N1}, {Center.Y:N1}): p1 = ({myP1.X:N1}, {myP1.Y:N1}): p2 = ({myP2.X:N1}, {myP2.Y:N1}): p3 = ({myP3.X:N1}, {myP3.Y:N1})";
        }
    }
}